using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash_state : Action_state_rules
{
    public GameObject player;
    public GameObject enemy;
    Animator walk_anim;

    private float distance_enemy_player;
    private bool is_at_melee_range;
    private float enemyWidth;

    float calc_x_distance(GameObject object1, GameObject object2)
    {
        return object1.transform.position.x - object2.transform.position.x;
    }

    public override void animate()
    {
        walk_anim = GetComponent<Animator>();
        enemyWidth = enemy.transform.localScale.x;

        distance_enemy_player = calc_x_distance(enemy, player);
        StartCoroutine(walk_to_player(0.01f, distance_enemy_player));
        //Debug.Log("distance: " + distance_enemy_player);

        StartCoroutine(walk_to_player(0.05f, distance_enemy_player));

    }

    public override void exit_state()
    {
        throw new System.NotImplementedException();
    }

    private IEnumerator walk_to_player(float speed, float distance)
    {
        if (distance > enemyWidth*2 && distance < 10f)
        {
            if (!is_at_melee_range)
            {
                enemy.transform.position = new Vector3(enemy.transform.position.x - speed, enemy.transform.position.y, enemy.transform.position.z);
                walk_anim.SetBool("startWalkAnim", true);
            }
            
            is_at_melee_range = false;
            yield return null;
        }
        else if (distance < -enemyWidth*2 && distance > -10f)
        {
            if (!is_at_melee_range)
            {
                enemy.transform.position = new Vector3(enemy.transform.position.x + speed, enemy.transform.position.y, enemy.transform.position.z);
                enemy.transform.localScale = new Vector2(-1, enemy.transform.localScale.y);
                walk_anim.SetBool("startWalkAnim", true);
            }
            is_at_melee_range = false;
            yield return null;
        }
        else
        {
            is_at_melee_range = true;
            walk_anim.SetBool("startWalkAnim", false);
            yield return null;
        }
    }
}