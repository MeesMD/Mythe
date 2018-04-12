using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash_state : Action_state_rules
{
    public GameObject player;
    public GameObject enemy;

    private float distance_enemy_player;

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    public override void animate()
    {
        Debug.Log("This is slash");
        distance_enemy_player = calc_x_distance(enemy, player);
        StartCoroutine(walk_to_player(0.1f, distance_enemy_player));
    }

    public override void exit_state()
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator walk_to_player(float speed, float distance)
    {
        if (distance > 0 && distance < 10f)
        {
            enemy.transform.position = new Vector3(enemy.transform.position.x - speed, enemy.transform.position.y, enemy.transform.position.z);
            yield return null;
        }
        else if (distance < 0 && distance > -10f)
        {
            enemy.transform.position = new Vector3(enemy.transform.position.x + speed, enemy.transform.position.y, enemy.transform.position.z);
            yield return null;
        }
    }
}
