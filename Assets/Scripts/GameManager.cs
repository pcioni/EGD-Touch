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

	public Card current_card;
	int cards_left;

    void Start() {
        dictionary = GameObject.Find("Dictionary");
        dictionaryOpened = false;
        dictionary.SetActive(dictionaryOpened);
        levelGenerator = GetComponent<GenerateLevel>();
    }

    void StartGame() {
        Debug.Log("Starting game from button press...");
        levelGenerator.setSize(lengthInput.text, widthInput.text);
        cards_left = levelGenerator.Generate();
        TitleGUI_Disable(); 
		current_card = null;
    }
    void toggleDictionary()
    {
        dictionaryOpened = !dictionaryOpened;
        dictionary.SetActive(dictionaryOpened);
    }
    public void found_pair(){
		Debug.Log ("You found a match!");
		cards_left -= 2;
		if (cards_left <= 0) {
			ReturnToTitle ();
			Debug.Log ("You matched all the cards!");
		}
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
