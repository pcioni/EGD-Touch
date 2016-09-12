using UnityEngine;
using System.Collections;

public class HandleTouch : MonoBehaviour {

    public int rotationSpeed = 1;

    bool isMatched = false;
    bool isFlipped = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown() {
        // animate flip
        if (!isFlipped) {
            isFlipped = true;
            StartCoroutine(animateFlip(false));
            print("touched the card with letter " + GetComponent<Card>().letter);
        }

        // TODO: handle logic
    }

    public void unFlip() {
        StartCoroutine(animateFlip(true));
    }

    IEnumerator animateFlip(bool unflip) {

        // The first time we flip over a card, play the pattern associated
        if (!unflip) {
			long[] pattern = MorseCode.A; // code pattern goes here

            if (Vibration.HasVibrator()) {
                // stop any currently playing vibrations
                Vibration.Cancel();
                Vibration.Vibrate(pattern, -1);
            }
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
