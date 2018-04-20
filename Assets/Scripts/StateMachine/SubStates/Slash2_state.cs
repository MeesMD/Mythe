using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash2_state : Action_state_rules
{
    public GameObject player;
    public GameObject enemy;

    private float distance_enemy_player;
    private bool is_at_melee_range;

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    public override void animate()
    {
        //throw new System.NotImplementedException();
        Debug.Log("This is slash2");
        distance_enemy_player = calc_x_distance(enemy, player);
        StartCoroutine(walk_to_player(0.1f, distance_enemy_player));
        Debug.Log("distance: " + distance_enemy_player);
    }

    public override void exit_state()
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator walk_to_player(float speed, float distance)
    {
        if (distance > 2 && distance < 10f)
        {
            if (!is_at_melee_range)
            {
                enemy.transform.position = new Vector3(enemy.transform.position.x - speed, enemy.transform.position.y, enemy.transform.position.z);
            }
            is_at_melee_range = false;
            yield return null;
        }
        else if (distance < -2 && distance > -10f)
        {
            if (!is_at_melee_range)
            {
                enemy.transform.position = new Vector3(enemy.transform.position.x + speed, enemy.transform.position.y, enemy.transform.position.z);
            }
            is_at_melee_range = false;
            yield return null;
        }
        else
        {
            is_at_melee_range = true;
            yield return null;
        }
    }
}
