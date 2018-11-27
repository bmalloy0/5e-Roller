using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndStrDis : MonoBehaviour {

    Slider IndStr;

    // Use this for initialization
    void Start()
    {
        IndStr = FindObjectOfType<IndividualSlider>().GetComponent<Slider>();
    }

    public void UpdateNum()
    {
        GetComponent<Text>().text = IndStr.value.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
