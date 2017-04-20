using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathScreenCtrl : MonoBehaviour {

    public string MainMenuLv;
    public string resetLv;

    public float waitToReload;
    private bool reloading;
    private GameObject thePlayer;

    public DeathScreenCtrl deathScreen;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void restartLv()
    {
        SceneManager.LoadScene(Application.loadedLevel);

    }


    public void mainMenuNav()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
