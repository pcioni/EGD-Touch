using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject[] GUI;
    private GenerateLevel levelGenerator;

    public Text lengthInput;
    public Text widthInput;

    public GameObject dictionary;
    public bool dictionaryOpened;

    public GameObject restartButton;

	public Card current_card;
	int cards_left;

    void Awake() {
        dictionary = GameObject.Find("Dictionary");
        dictionaryOpened = false;
        dictionary.SetActive(dictionaryOpened);
        levelGenerator = GetComponent<GenerateLevel>();
    }

    void StartGame() {
        if (lengthInput.text == "1" && widthInput.text == "1") {
            Debug.Log("Invalid width or length (values of 1)");
            return;
        }
        Debug.Log("Starting game from button press...");
        levelGenerator.setSize(lengthInput.text, widthInput.text);
        cards_left = levelGenerator.Generate();
        TitleGUI_Disable(); 
		current_card = null;
    }
    void toggleInfo()
    {
        dictionaryOpened = !dictionaryOpened;
        dictionary.SetActive(dictionaryOpened);
        restartButton.SetActive( !restartButton.activeSelf );
    }
    public void found_pair(){
		Debug.Log ("You found a match!");
		cards_left -= 2;
		if (cards_left <= 0) {
			ReturnToTitle ();
			Debug.Log ("You matched all the cards!");
		}
	}

    public void ReturnToTitle() {
        //just reloads the scene. Use Awake to reset variables, unlike Start.
        Application.LoadLevel(0);
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
