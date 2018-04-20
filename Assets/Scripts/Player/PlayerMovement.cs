using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    private float _speedMult = 1;
    private float _speedDec  = 0.75f;
    private float _maxSpeed  = 5;
    private float _curSpeed  = 0;

    // Use this for initialization
    void Start()
    {
        if (!(inputManager = this.GetComponent<InputManager>()))
		   inputManager = this.gameObject.AddComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.Right())
        {
            _curSpeed += _speedMult;

            if (_curSpeed >= _maxSpeed)
            {
                _curSpeed = _maxSpeed;
            }
        }

        else if (inputManager.Left())
        {
            _curSpeed -= _speedMult;

            if (_curSpeed <= -_maxSpeed)
            {
                _curSpeed = -_maxSpeed;
            }
        }

        else
        {
            _curSpeed *= _speedDec;

            if (_curSpeed > -_speedMult && _curSpeed < _speedMult)
            {
                _curSpeed = 0;
            }
        }
        transform.Translate(_curSpeed * Time.deltaTime, 0, 0);
    }
}