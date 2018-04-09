using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GroundChecker))]
public class PlayerJump : MonoBehaviour
{
    private InputManager inputManager;
    private GroundChecker groundChecker;
    private Rigidbody2D _rb;
    private float _jumpVel = 6;
    private float _gravity = 2.5f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        if (!(inputManager = this.GetComponent<InputManager>()))
        {
            inputManager = this.gameObject.AddComponent<InputManager>();
        }

        if (!(groundChecker = this.GetComponent<GroundChecker>()))
        {
            groundChecker = this.gameObject.AddComponent<GroundChecker>();
        }
    }


    void Update()
    {
        groundChecker.isGrounded();

        if (inputManager.Up() && groundChecker.isGrounded())

        if (inputManager.Up())

            _rb.velocity = Vector2.up * _jumpVel;

        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * _gravity * Time.deltaTime;
        }
    }
}
