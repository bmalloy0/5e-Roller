using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndNumDis : MonoBehaviour {

    Slider NumInd;

	// Use this for initialization
	void Start () {
        NumInd = FindObjectOfType<IndivNumSlider>().GetComponent<Slider>();
	}

    public void UpdateNum() {
        GetComponent<Text>().text = NumInd.value.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
