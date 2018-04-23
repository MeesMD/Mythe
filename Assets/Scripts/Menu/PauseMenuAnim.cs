using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuAnim : MonoBehaviour {

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        anim.SetBool("isHoveringOver", true);
    }

    void OnMouseExit()
    {
        anim.SetBool("isHoveringOver", false);
    }
}
