using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public float scoreCounter;
    public float hiScoreCounter;

    //How many points you get the longer you survive
    public float pointsPerSecond;

    public bool scoreIncrease;

    public GameObject player;


	// Use this for initialization
	void Start () {
	    if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiScoreCounter = PlayerPrefs.GetFloat("HighScore");
        }

	}
	
	// Update is called once per frame
	void Update () {

        //Increaseing the Score Every Second

        if (player.activeSelf)
        {
            scoreCounter += pointsPerSecond * Time.deltaTime;
            if (scoreCounter > hiScoreCounter)
            {
                 hiScoreCounter = scoreCounter;
                PlayerPrefs.SetFloat("HighScore", hiScoreCounter);
            }
                scoreText.text = "Score : " + Mathf.Round(scoreCounter);
                hiScoreText.text = "Highscore : " + Mathf.Round(hiScoreCounter);
         

        }
	}
}
