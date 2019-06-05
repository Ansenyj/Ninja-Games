using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            { 
            if (Time.timeScale == 0)
                Time.timeScale = 1;
            else Time.timeScale = 0;
        }


    }
}
