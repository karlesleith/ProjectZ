using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuCtrl : MonoBehaviour {

    public Button Arcade_btn;
  
 
	// Use this for initialization
	void Start () {

        Arcade_btn.onClick.AddListener(() => { SceneManager.LoadScene("TestLV1"); });
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
