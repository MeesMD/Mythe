using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float Health = 20f;
    void ApplyDamage(float damage)
    {
        Health -= damage;
        Debug.Log(Health);
    }
    private void Update()
    {
        if (Health < 0){
            Debug.Log("I got fucked");
        }
    }

}
