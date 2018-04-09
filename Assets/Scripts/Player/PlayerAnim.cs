using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {

    private InputManager inputManager;
    private GroundChecker groundChecker;
    Animator anim;

	void Start () {
        anim = GetComponent<Animator>();

        if (!(inputManager = this.GetComponent<InputManager>()))
            inputManager = this.gameObject.AddComponent<InputManager>();

        if (!(groundChecker = this.GetComponent<GroundChecker>()))
            groundChecker = this.gameObject.AddComponent<GroundChecker>();
    }
	
	
	void Update () {
        //Jump
        if (groundChecker.isGrounded())
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }


        //Walk
        if (inputManager.Right())
        {
            anim.SetBool("Walk", true);

            //Verander waarde van Vector2 voor grote speler!
            transform.localScale = new Vector2(0.7f, 0.7f);
        }

        else if (inputManager.Left())
        {
            anim.SetBool("Walk", true);

            //Verander waarde van Vector2 voor grote speler!
            transform.localScale = new Vector2(-0.7f, 0.7f);
        }

        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
