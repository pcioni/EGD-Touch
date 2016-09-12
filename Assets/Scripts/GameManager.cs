using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text titleText;
    public GameObject startButton;
    private GenerateLevel levelGenerator;

    void Start() {
        levelGenerator = GetComponent<GenerateLevel>();
    }

    void StartGame() {
        Debug.Log("Starting game from button press...");
        levelGenerator.Generate();
        TitleGUI_Disable();
    }

    void ReturnToTitle() {
        
    }

    void TitleGUI_Disable() {
        titleText.enabled = false;
        startButton.SetActive(false);
    }

    void TitleGUI_Enable() {
        titleText.enabled = true;
        startButton.SetActive(false);
    }

}
