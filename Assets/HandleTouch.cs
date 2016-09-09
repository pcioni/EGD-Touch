using UnityEngine;
using System.Collections;

public class HandleTouch : MonoBehaviour {

    public int rotationSpeed = 1;

    bool isMatched = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown() {
        // animate flip
        StartCoroutine(animateFlip());

        // TODO: handle logic and play vibration
    }

    IEnumerator animateFlip() {
		for (int i = 0; i < 180; i += rotationSpeed) {
			gameObject.transform.Rotate (new Vector3 (0, rotationSpeed, 0));
            yield return null;
		}
	}
}
