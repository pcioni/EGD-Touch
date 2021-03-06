﻿using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

	public char letter;

    public void setLetterSprite()
    {
        float scale = 3.2f;
        string assetPath = "MorseCode/" + letter;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(assetPath);
        GetComponent<BoxCollider2D>().size = new Vector2(1 / scale, 1 / scale);
        transform.localScale = new Vector3(scale * -1, scale);
      //  this.gameObject.transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, 180 * Mathf.Deg2Rad, transform.localRotation.z));
    }
}

