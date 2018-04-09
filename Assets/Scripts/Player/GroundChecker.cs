using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RaycastCreator))]
public class GroundChecker : MonoBehaviour {

    private RaycastCreator raycastCreator;
    public bool isgrounded;

    void Start()
    {
        if (!(raycastCreator = this.GetComponent<RaycastCreator>()))
        {
            raycastCreator = this.gameObject.AddComponent<RaycastCreator>();
        }
    }

    void checkIfGrounded()
    {
        if (raycastCreator.touchingFloor())
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
        }
    }

    public bool isGrounded()
    {
        checkIfGrounded();
        return isgrounded;
    }
    
	
}
