using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RaycastCreator))]
public class GroundChecker : MonoBehaviour {

    private RaycastCreator raycastCreator;
    private bool canJump = false;

    void Start()
    {
        if (!(raycastCreator = this.GetComponent<RaycastCreator>()))
        {
            raycastCreator = this.gameObject.AddComponent<RaycastCreator>();
        }
    }

    void Update()
    {
        if (raycastCreator.isgrounded())
        {
            canJump = false;
        }
    }
    
	
}
