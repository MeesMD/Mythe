using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Debug.Log("hit");
            coll.gameObject.SendMessage("ApplyDamage", 10, SendMessageOptions.RequireReceiver);
        }
    }
}
