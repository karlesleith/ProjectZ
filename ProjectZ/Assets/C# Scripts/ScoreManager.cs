using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public float scoreCounter;
    public float hiScoreCounter;

    public float pointsPerSecond;

    public bool scoreIncrease;

    public GameObject player;


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

        //Increaseing the Score Every Second

        if (player.activeSelf)
        {

            scoreCounter += pointsPerSecond * Time.deltaTime;
            scoreText.text = "Score : " + Mathf.Round(scoreCounter);
            hiScoreText.text = "Highscore : " + hiScoreCounter;

        }
	}
}
