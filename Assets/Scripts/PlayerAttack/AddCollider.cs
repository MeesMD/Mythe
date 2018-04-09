using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCollider : MonoBehaviour {
    BoxCollider2D bc;

    void Start () {
        if (!(bc = this.GetComponent<BoxCollider2D>()))
        {
            bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        }

        bc.enabled = false;

    }


}
