﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	//Declaring Varibles
	public float moveSpeed;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMovement;


	// Use this for initialization
	void Start () {
        
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //At the start of every frame set the Player Movemnet to Flase
        playerMoving = false;

        //Horizontal Player Movement
        if (Input.GetAxisRaw("Horizontal") > 0.5f ||  (Input.GetAxisRaw("Horizontal") < -0.5f)){
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
            playerMoving = true;
            lastMovement = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);	
        }

		//Vertical Player Movement
		if(Input.GetAxisRaw("Vertical") > 0.5f ||  (Input.GetAxisRaw("Vertical") < -0.5f)){
			transform.Translate (new Vector3 (0f,Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime,0f));
            playerMoving = true;
            lastMovement = new Vector2(0f,Input.GetAxisRaw("Vertical"));
        }

        //Set Animations
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMovement.x);
        anim.SetFloat("LastMoveY", lastMovement.y);
    }
}