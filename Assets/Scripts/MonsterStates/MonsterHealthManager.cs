using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealthManager : MonoBehaviour {

    [SerializeField] Image h1;
    [SerializeField] Image h2;
    [SerializeField] Image h3;
    [SerializeField] Image h4;
    [SerializeField] Image h5;

    [SerializeField] GameObject enemy;

    Minotaur minotaur_script;

    int enemy_health;

	// Use this for initialization
	void Start () {
        minotaur_script = enemy.GetComponent<Minotaur>();
	}
	
	// Update is called once per frame
	void Update () {
        enemy_health = minotaur_script.health;
        switch (enemy_health)
        {
            case 80:
               Destroy(h5);
                break;
            case 60:
                Destroy(h4);
                break;
            case 40:
                Destroy(h3);
                break;
            case 20:
                Destroy(h2);
                break;
            case 0:
                Destroy(h1);
                break;
        }
	}
}
