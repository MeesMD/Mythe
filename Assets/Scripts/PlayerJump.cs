using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    private InputManager inputManager;
    private GroundChecker isGrounded;
    private Rigidbody2D _rb;
    private float _jumpVel = 6;
    private float _fallMult = 2.5f;
	
	void Start () {
        _rb = GetComponent<Rigidbody2D>();

        if (!(inputManager = this.GetComponent<InputManager>()))
        {
            inputManager = this.gameObject.AddComponent<InputManager>();
        }
    }
	
	
	void Update () {
        if (isGrounded == true)
        {
            if (inputManager.Up())
                _rb.velocity = Vector2.up * _jumpVel;

            if (_rb.velocity.y < 0)
            {
                _rb.velocity += Vector2.up * Physics2D.gravity.y * _fallMult * Time.deltaTime;
            }
        }
	}
}
