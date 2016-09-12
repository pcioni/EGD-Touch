using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject[] GUI;
    private GenerateLevel levelGenerator;
    public Text lengthInput;
    public Text widthInput;

    void Start() {
        levelGenerator = GetComponent<GenerateLevel>();
    }

    void StartGame() {
        Debug.Log("Starting game from button press...");
        levelGenerator.setSize(lengthInput.text, widthInput.text);
        levelGenerator.Generate();
        TitleGUI_Disable();
    }

    void ReturnToTitle() {
        
    }

    void TitleGUI_Disable() {
        foreach (GameObject go in GUI) {
            go.SetActive(false);
        }
    }

    void TitleGUI_Enable() {
        foreach (GameObject go in GUI) {
            go.SetActive(true);
        }
    }

}
