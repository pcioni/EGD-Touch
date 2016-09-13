using UnityEngine;
using System.Collections;

public class HandleTouch : MonoBehaviour {

    public int rotationSpeed = 1;

    bool isMatched = false;
    bool isFlipped = false;

	GameManager manager;

	// Use this for initialization
	void Start () {
		manager = FindObjectOfType<GameManager> ();
	}

    void OnMouseDown() {

		if (isMatched) {
			return;
		}

        // animate flip
        if (!isFlipped) {
            isFlipped = true;
            StartCoroutine(animateFlip(false));
            print("touched the card with letter " + GetComponent<Card>().letter);
        }

		if (manager.current_card == null) {
			manager.current_card = GetComponent<Card> ();
		} 
		else {
			if (GetComponent<Card> ().letter == manager.current_card.letter) {
				isMatched = true;
				manager.current_card.GetComponent<HandleTouch> ().isMatched = true;

                Card a, b;
                
                a = manager.current_card;
                b = GetComponent<Card> ();
                Debug.Log(b.letter);
                b.setLetterSprite();
                a.setLetterSprite();
              //  b.setLetterSprite();
            //    b = null;
                manager.current_card = null;
				manager.found_pair ();

            } 
			else {
				unFlip ();
				manager.current_card.GetComponent<HandleTouch> ().unFlip ();
				manager.current_card = null;
			}
		}
	}

    public void unFlip() {
        StartCoroutine(animateFlip(true));
    }

    IEnumerator animateFlip(bool unflip) {

        // The first time we flip over a card, play the pattern associated
		if (!unflip) {
			long[] pattern = MorseCode.GetPattern (GetComponent<Card> ().letter); // code pattern goes here

			if (Vibration.HasVibrator ()) {
				// stop any currently playing vibrations
				Vibration.Cancel ();
				Vibration.Vibrate (pattern, -1);
			}
		} else {
			yield return new WaitForSeconds (rotationSpeed / 2);
			Debug.Log ("Sorry, that wasn't a match.");
		}
        
        // animate the card rotation
		for (int i = 0; i < 180; i += rotationSpeed) {
			gameObject.transform.Rotate (new Vector3 (0, rotationSpeed, 0));
            yield return null;
		}

        // and set back to unflipped status
        if (unflip)
            isFlipped = false;
	}
}
