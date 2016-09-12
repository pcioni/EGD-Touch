using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text titleText;
    public GameObject startButton;
    private GenerateLevel levelGenerator;

	public Card current_card;
	int cards_left;

    void Start() {
        levelGenerator = GetComponent<GenerateLevel>();
    }

    void StartGame() {
        Debug.Log("Starting game from button press...");
        cards_left = levelGenerator.Generate();
        TitleGUI_Disable();
		current_card = null;
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
        titleText.enabled = false;
        startButton.SetActive(false);
    }

    void TitleGUI_Enable() {
        titleText.enabled = true;
        startButton.SetActive(false);
    }

}
