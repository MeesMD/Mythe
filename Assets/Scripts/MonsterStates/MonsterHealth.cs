using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour {

    public GameObject enemy;

    public int health_points = 5;
    private bool dead = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (health_points <= 0 && dead == false)
        {
            dead = true;
        }
        if (dead)
        {
            Destroy(enemy);
        }
	}
}
