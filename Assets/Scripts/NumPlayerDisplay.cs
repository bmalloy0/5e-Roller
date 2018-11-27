using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPlayerDisplay : MonoBehaviour {

    Text playerLevel;
    Slider playerSlider;

    void Start()
    {
        playerLevel = GetComponent<Text>();
        Debug.Log(playerLevel.name);
        playerSlider = FindObjectOfType<PlayerNumSlider>().GetComponent<Slider>();
        Debug.Log(playerSlider.name);
    }

    public void UpdateNum()
    {
        playerLevel.text = playerSlider.value.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
