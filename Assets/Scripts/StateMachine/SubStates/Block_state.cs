using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_state : Action_state_rules {

    public override void animate()
    {
        //throw new System.NotImplementedException();
        Debug.Log("This is block");
    }

    public override void exit_state()
    {
        throw new System.NotImplementedException();
    }
}
