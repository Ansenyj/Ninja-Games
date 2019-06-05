using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text txt = this.GetComponent<Text>();
        string score= PlayerPrefs.GetFloat("BestScore").ToString() ;
        txt.text = "YOUR BEST: "+score;
	}

    // Update is called once per frame
    
}
