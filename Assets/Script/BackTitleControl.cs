using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackTitleControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
           
                UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
            
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
