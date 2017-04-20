using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour {

    public float moveSpeed;
    private bool moving;

    //Creating body for the Enemy
    private Rigidbody2D myRigidBody;

    public float timeToMove;
    private float timeToMoveCounter;
    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    private Vector3 moveDirection;

    public float waitToReload;
    private bool reloading;
    private GameObject thePlayer;

    public GameObject deathScreen;

    // Use this for initialization
    void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        

        /*
        timeBetweenMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;
        */
        timeBetweenMoveCounter = Random.Range(timeBetweenMove *.75f, timeBetweenMove * 1.75f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMove * 1.75f);
       
	}
	
	// Update is called once per frame
	void Update () {

        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;

            if(timeToMoveCounter < 0f)
            {
                moving = false;
                //timeBetweenMoveCounter = timeBetweenMove;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * .75f, timeBetweenMove * 1.75f);
            }

        }
        else{
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                //timeToMoveCounter = timeToMove;
                timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMove * 1.75f);
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(1f, -1f) * moveSpeed, 0f );
            }
        }
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if(waitToReload < 0)
            {
                Application.LoadLevel(Application.loadedLevel);
                thePlayer.SetActive(true);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.SetActive(false);

            deathScreen.gameObject.SetActive(true);

           // reloading = true;
            //thePlayer = other.gameObject;
        }
    }
}
