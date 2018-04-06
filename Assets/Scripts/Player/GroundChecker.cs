using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RaycastCreator))]
public class GroundChecker : MonoBehaviour {

    private RaycastCreator raycastCreator;

    void Start()
    {

    }

    void Update()
    {
        if (raycastCreator.isgrounded())
        {
            print("Yeet");
        }
    }
    
	
}
