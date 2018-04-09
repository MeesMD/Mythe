using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlash : MonoBehaviour {
	BoxCollider2D bc;

	public float size_x = 1.2f; 
	public float size_y = 1.1f;
	float range = 1.4f;
	public float duration = 0.4f;
    float timer = 0;
   



	void Update () 
	{
        Slash();
	}

    void Slash()
    {
        timer += Time.deltaTime;
        if (timer > duration)
        {
            bc.enabled = false;

            if (Input.GetKeyDown("space") & timer > duration + 0.25f)
            {
                bc.enabled = true;
                bc.size = new Vector2(size_x, size_y);
                bc.offset = bc.offset + new Vector2(range, 0);
                timer = 0;

            }

        }
    }
}
