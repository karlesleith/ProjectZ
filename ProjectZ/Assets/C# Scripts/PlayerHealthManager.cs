using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

    public GameObject deathScreen;

    // Use this for initialization
    void Start () {

        playerCurrentHealth = playerMaxHealth;
        MonoBehaviour.print(playerCurrentHealth);
    }
	
	// Update is called once per frame
	void Update () {

        //If the player runs out of health the players object is deactivated
        if (playerCurrentHealth <= 0)
        {
            playerCurrentHealth = 0;
            MonoBehaviour.print(playerCurrentHealth + "Taken");
            gameObject.SetActive(false);
            deathScreen.gameObject.SetActive(true);

        }
		
	}

    //Damage done to Player
    public void PlayerDamage(int damageToPlayer)
    {
        MonoBehaviour.print(playerCurrentHealth + "Taken");
        playerCurrentHealth -= damageToPlayer;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
