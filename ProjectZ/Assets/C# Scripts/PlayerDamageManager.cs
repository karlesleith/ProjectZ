using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour {

    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
         {
            MonoBehaviour.print("Hit");
            other.gameObject.GetComponent<PlayerHealthManager>().PlayerDamage(damage);
    }
    }
}
