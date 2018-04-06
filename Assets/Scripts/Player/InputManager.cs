using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public bool Up()
    {
        return Input.GetKeyDown("space");
    }
    public bool Left()
    {
        return Input.GetKey("a");
    }
    public bool Right()
    {
        return Input.GetKey("d");
    }
}
