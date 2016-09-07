using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
    public void quitGameOnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    public void levelSelectOnClick()
    {

    }
    public void dictionaryOnClick()
    {
        GameObject dictionary = GameObject.FindGameObjectWithTag("Dictionary");
        GameObject menu = GameObject.Find("MainMenu");

        dictionary.SetActive(true);
        menu.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
