using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour {
    BoxCollider2D bc;
    public float slash_size_x = 1.2f;
    public float slash_size_y = 1.1f;
    public float slash_duration = 0.4f;
    public float stab_size_x = 1.5f;
    public float stab_size_y = 0.4f;
    public float stab_duration = 0.3f;
    float range = 1.4f;
 
    float timer = 0;


    private void Start()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
    }
 

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > slash_duration && timer > stab_duration)
        {
            bc.enabled = false;
            Slash();
            Stab();
        }
    }


    void Slash()
    {
        if (Input.GetKeyDown("space") & timer > slash_duration + 0.25f)
        {
            bc.enabled = true;
            bc.size = new Vector2(slash_size_x, slash_size_y);
            bc.offset = new Vector2(range, 0);
            timer = 0;

        }
    }


    void Stab()
    {
        if (Input.GetKeyDown(KeyCode.C) & timer > stab_duration + 0.25f)
        {
            bc.enabled = true;
            bc.size = new Vector2(stab_size_x, stab_size_y);
            bc.offset = new Vector2(range, 0);
            timer = 0;

        }
    }
}
