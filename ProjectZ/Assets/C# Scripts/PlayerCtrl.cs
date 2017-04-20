using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	//Declaring Varibles
	public float moveSpeed;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMovement;
    private Rigidbody2D myRB;

    private bool playerAttacking;
    public float attackTime;
    private float attackTimeCnt;

    public AudioClip attackSound;



	// Use this for initialization
	void Start () {
        //Getting the Unity Components 
        anim = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //At the start of every frame set the Player Movemnet to Flase
        playerMoving = false;

        if (!playerAttacking)
        {

            //Horizontal Player Movement
            if (Input.GetAxisRaw("Horizontal") > 0.5f || (Input.GetAxisRaw("Horizontal") < -0.5f))
            {
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRB.velocity.y);
                playerMoving = true;
                lastMovement = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            //Vertical Player Movement
            if (Input.GetAxisRaw("Vertical") > 0.5f || (Input.GetAxisRaw("Vertical") < -0.5f))
            {
                transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRB.velocity = new Vector2(myRB.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
                playerMoving = true;
                lastMovement = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }


            //When the Character is moving, the force of the rigid body still moves him when you dont have the keypad pressed, these next 
            //2 ifs reset his X & Y momentum 2 zero
            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {

                myRB.velocity = new Vector2(0f, myRB.velocity.y);

            }
            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {

                myRB.velocity = new Vector2(myRB.velocity.x, 0f);

            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                attackTimeCnt = attackTime;
                playerAttacking = true;
                myRB.velocity = Vector2.zero;
                anim.SetBool("PlayerAttacking", true);

                GetComponent<AudioSource>().Play();
            }

            playerAttacking = false;

            if (attackTimeCnt > 0)
            {

                attackTimeCnt -= Time.deltaTime;
            }

            if(attackTimeCnt <= 0)
            {
           
                anim.SetBool("PlayerAttacking", false);
            }


        }
        //Set Animations
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMovement.x);
        anim.SetFloat("LastMoveY", lastMovement.y);
    }
}