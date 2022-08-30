using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _xMin = -19.2f;

    [SerializeField]
    private float _xMax = 19.2f;

    [SerializeField]
    private float _moveSpeed = 5f;

    private float _initialMousePos = 0f;

    [SerializeField]
    private float _force = 0f;

    [SerializeField]
    private float _forceError = 0.01f;

    [SerializeField]
    private float _brake = 7f;

    private bool _useForce = false;

    private Vector3 _nextPos = Vector3.zero;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _initialMousePos = Input.mousePosition.x / Screen.width * 2f - 1f;
        }
        else if (Input.GetMouseButton(0))
        {
            float delta = (Input.mousePosition.x / Screen.width * 2f - 1f - _initialMousePos) * 0.5f;
            _force -= delta * delta * delta * 1000f;

            _useForce = true;

            _initialMousePos = Input.mousePosition.x / Screen.width * 2f - 1f;
        }


        if (_force < 0f)
        {
            _force = _force - _force * _brake * Time.deltaTime;

            if (_force + _forceError > 0f)
            {
                _force = 0f;
                _useForce = false;
            }
        }
        else if (_force > 0f)
        {
            _force = _force - _force * _brake * Time.deltaTime;

            if (_force - _forceError < 0f)
            {
                _force = 0f;
                _useForce = false;
            }
        }


        if (_useForce)
        {
            _nextPos = _target.position;


            if (_force < 0f)
            {
                _nextPos = Vector3.MoveTowards(_target.position,
                new Vector3(_xMin, _target.position.y, _target.position.z), _moveSpeed * Time.deltaTime);
            }
            else if (_force > 0f)
            {
                _nextPos = Vector3.MoveTowards(_target.position,
                new Vector3(_xMax, _target.position.y, _target.position.z), _moveSpeed * Time.deltaTime);
            }


            _target.position = _nextPos;
        }
    }
}
