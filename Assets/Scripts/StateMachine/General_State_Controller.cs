using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using States;

public class General_State_Controller : MonoBehaviour
{

    [SerializeField]
    public GameObject player;
    public GameObject enemy;

    //add possible substates like this:
    //public Action_state_rules[] Defensive_actions;

    //add possible states like this:
    //private Defensive D_state;

    public int health = 100;
    public float trigger_distance = 10f;
    public int health_trigger = 20;

    private bool state_passive;
    private bool state_aggressive;
    private bool state_defensive;

    private bool trigger_left;
    private bool trigger_right;

    // Use this for initialization
    void Start()
    {
        //and assign the state like this:
        // D_state = gameObject.AddComponent<Defensive>();

        state_passive = true;
    }

    void check_if_passive()
    {
        if (health >= health_trigger && trigger_left == false
            && trigger_right == false)
        {
            state_passive = true;
            state_aggressive = false;
            state_defensive = false;
        }
    }

    void check_if_aggressive()
    {
        if (health > health_trigger && (trigger_left
                            || trigger_right))
        {
            state_passive = false;
            state_aggressive = true;
            state_defensive = false;
        }
    }

    void check_if_defensive()
    {
        if (health <= health_trigger)
        {
            state_passive = false;
            state_aggressive = false;
            state_defensive = true;
        }
    }

    void state_checker()
    {
        check_if_passive();
        check_if_defensive();
        check_if_aggressive();
    }

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    void check_triggers()
    {
        float distance = calc_x_distance(player, enemy);
        if (distance <= trigger_distance && distance < 0)
        {
            trigger_left = true;
            trigger_right = false;
        }
        else if (distance >= -trigger_distance && distance > 0)
        {
            trigger_left = false;
            trigger_right = true;
        }
        if (distance > trigger_distance || distance < -trigger_distance)
        {
            trigger_left = false;
            trigger_right = false;
        }
    }

    void state_switcher()
    {
        //add possible states like this:
        /*
         * if (state_defensive)
         *    {
         *      D_state.state_update(Defensive_actions);
         *    }
        */
    }

    // Update is called once per frame
    void Update()
    {
        state_checker();
        check_triggers();
        state_switcher();
    }
}
