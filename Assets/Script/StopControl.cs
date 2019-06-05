using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopControl : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else Time.timeScale = 1;
        });
	}
}
