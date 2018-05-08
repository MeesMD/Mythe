using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using States;

public class Minotaur : MonoBehaviour {

    [SerializeField]
    public GameObject player;
    public GameObject minotaur;
    
    public Action_state_rules[] Aggressive_actions;
    public Action_state_rules[] Defensive_actions;

    private Defensive D_state;// = new Defensive();
    private Aggressive A_state;// = new Aggressive();

    public int health = 100;
    private bool vulnerable = true;
    public float trigger_distance = 10f;

    private bool state_passive;
    private bool state_aggressive;
    private bool state_defensive;

    private bool trigger_left;
    private bool trigger_right;

	// Use this for initialization
	void Start ()
    {
        state_passive = true;
        D_state = gameObject.AddComponent<Defensive>();
        A_state = gameObject.AddComponent<Aggressive>();
    }
	
    void check_if_passive()
    {
        if (health >= 20 && trigger_left == false
            && trigger_right == false)
        {
            state_passive = true;
            state_aggressive = false;
            state_defensive = false;
        }
    }

    void check_if_aggressive()
    {
        if (health > 0 && (trigger_left 
                            || trigger_right))
        {
            state_passive = false;
            state_aggressive = true;
            state_defensive = false;
        }
    }

    void check_if_defensive()
    {
        if (health <= 20)
        {
            state_passive = false;
            state_aggressive = false;
            state_defensive = true;
        }
    }

    void state_checker()
    {
        check_if_passive();
        //check_if_defensive();
        check_if_aggressive();
    }

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    void check_triggers()
    {
        float distance = calc_x_distance(player, minotaur);
        if(distance <= trigger_distance && distance < 0)
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
        if (state_aggressive)
        {
            A_state.state_update(Aggressive_actions);
        }
        if (state_defensive)
        {
            D_state.state_update(Defensive_actions);
        }
    }

    void ApplyDamage(int damage)
    {
        if (vulnerable && health != 0)
        {
            vulnerable = false;
            health -= damage;
            StartCoroutine(CantBeHit());
            vulnerable = true;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        state_checker();
        check_triggers();
        state_switcher();

        Debug.Log(health);

        if (health <= 0)
        {
            Destroy(minotaur);
        }
    }

    IEnumerator CantBeHit()
    {
        
        yield return new WaitForSeconds(.3f);
        vulnerable = true;
    }
}
