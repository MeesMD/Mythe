using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash_state : Action_state_rules
{
    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    /*bool check_if_in_range()
    {
        if(calc_x_distance(this,player))
    }*/

    public override void animate()
    {
        
        Debug.Log("This is slash");
    }

    public override void exit_state()
    {
        throw new System.NotImplementedException();
    }
}
