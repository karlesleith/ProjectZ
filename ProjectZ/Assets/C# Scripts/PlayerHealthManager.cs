using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

	// Use this for initialization
	void Start () {

        playerCurrentHealth = playerMaxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

        //If the player runs out of health the players object is deactivated
        if (playerCurrentHealth < 0)
        {
            gameObject.SetActive(false);

        }
		
	}

    public void PlayerDamage(int damageToPlayer)
    {
        playerCurrentHealth -= damageToPlayer;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
