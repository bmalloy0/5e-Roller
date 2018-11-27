using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HordeDisplay : MonoBehaviour {

    Text hordeStrength;
    Slider hordeSlider;

    void Start()
    {
        hordeStrength = GetComponent<Text>();

        hordeSlider = FindObjectOfType<HordeSlider>().GetComponent<Slider>();
        
    }

    public void UpdateNum()
    {
        hordeStrength.text = hordeSlider.value.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
