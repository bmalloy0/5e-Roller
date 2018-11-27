using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToMainMenu : MonoBehaviour {

    Button self;
    LevelManager loader;

	// Use this for initialization
	void Start () {
        self = GetComponent<Button>();
        loader = FindObjectOfType<LevelManager>();
        Debug.Log(loader.name);
	}

    public void Back() {
        loader.LoadLevel("Main Menu");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
