using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBoundChecker : MonoBehaviour
{
    FadingScript fadingScript;

    void Start()
    {
        GameObject fadingObject = GameObject.Find("Level Changer");
        fadingScript = fadingObject.GetComponent<FadingScript>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "BossBoundary")
        {
            fadingScript.Fade();
        }
    }
}
