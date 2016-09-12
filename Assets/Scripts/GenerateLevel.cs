using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateLevel : MonoBehaviour {

	public Vector2 size;
	GameObject card;
	List<GameObject> cards;


	// Use this for initialization
	public void Generate () {

		//Calculates the proper sizing of the board spawns all of the cards in their proper locations.

		card = (GameObject) Resources.Load ("Square");
		cards = new List<GameObject> ();
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
					cards.Add((GameObject) Instantiate (card, current_location, Quaternion.identity));
				}
				current_location += new Vector3 (1.2f, 0f, 0f);
			}
			current_location = new Vector3 (left, current_location.y + 1.2f, 0f);
		}

		//Assigns the cards their letters.

		List<char> letters = new List<char>() {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
		letters = Fisher_Yates_Shuffle (letters);
		cards = Fisher_Yates_Shuffle (cards);

		for (int x = 0; x < cards.Count; x += 2) {
			cards [x].GetComponent<Card> ().letter = letters [x/2];
			cards [x + 1].GetComponent<Card> ().letter = letters [x / 2];
			print("assigning two cards the letter " + letters[x/2]);
		}


	}

	public static List<char> Fisher_Yates_Shuffle (List<char> aList) {

		System.Random _random = new System.Random ();

		char myGO;

		int n = aList.Count;
		for (int i = 0; i < n; i++)
		{
			// NextDouble returns a random number between 0 and 1.
			// ... It is equivalent to Math.random() in Java.
			int r = i + (int)(_random.NextDouble() * (n - i));
			myGO = aList[r];
			aList[r] = aList[i];
			aList[i] = myGO;
		}

		return aList;
	}

	public static List<GameObject> Fisher_Yates_Shuffle (List<GameObject>aList) {

		System.Random _random = new System.Random ();

		GameObject myGO;

		int n = aList.Count;
		for (int i = 0; i < n; i++)
		{
			// NextDouble returns a random number between 0 and 1.
			// ... It is equivalent to Math.random() in Java.
			int r = i + (int)(_random.NextDouble() * (n - i));
			myGO = aList[r];
			aList[r] = aList[i];
			aList[i] = myGO;
		}

		return aList;
	}
}
