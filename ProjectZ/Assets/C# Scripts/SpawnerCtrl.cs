using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValues;

    public int startWait;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner());
	}
	
	// Update is called once per frame
	void Update () {

        spawnWait = Random.Range(spawnLeastWait,spawnMostWait);

	}

    //This Coroutine allows me to respawn the zombies over and over
    IEnumerator Spawner()
    {

        yield return new WaitForSeconds(startWait);

        while (true)
        {
            //Determins where on the map the enemies will be spawned
            Vector3 spawnPostiion = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),1,1);

            Instantiate(enemies[2], spawnPostiion + transform.TransformPoint(0,0,0),gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);

            spawnMostWait -= 20/100;

        }
    }
}
