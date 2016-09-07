using UnityEngine;
using System.Collections;

public class GenerateLevel : MonoBehaviour {

	public Vector2 size;
	public GameObject card;

	// Use this for initialization
	void Start () {
		card = (GameObject) Resources.Load ("Square");
		bool odd = false;
		if (Mathf.Floor(size.x * size.y) % 2 != 0) {
			odd = true;
		}
		float left = (float) -0.6 * (size.y - 1);
		float top = (float) -0.6 * (size.x - 1);
		Vector3 current_location = new Vector3 (left, top, 0f);
		for (int x = 0; x < size.x; x++) {
			for (int y = 0; y < size.y; y++) {
				if (odd && x == Mathf.Floor(size.x / 2) && y == Mathf.Floor(size.y / 2)) {
				} else {
					Instantiate (card, current_location, Quaternion.identity);
				}
				current_location += new Vector3 (1.2f, 0f, 0f);
			}
			current_location = new Vector3 (left, current_location.y + 1.2f, 0f);
		}
	}
}
