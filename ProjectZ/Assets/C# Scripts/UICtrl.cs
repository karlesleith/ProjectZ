﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICtrl : MonoBehaviour {

    public Slider healthBar;
    public Text HP;
    public PlayerHealthManager playerHealth;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HP.text = "HP: " + playerHealth.playerCurrentHealth + " /100";

    
	}
}
