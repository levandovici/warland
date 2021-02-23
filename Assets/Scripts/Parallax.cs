using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Header("Parallax Objects")]
    [SerializeField]
    private ParallaxLayer[] _parallaxLayers;

    private float _lastXPosition = 0;

    [SerializeField]
    private float _moveSpeed = 5f;

    private float _initialMousePos = 0f;

    [SerializeField]
    private float _force = 0f;

    [SerializeField]
    private float _brake = 3f;

    private bool _useForce = false;



    void Update()
    {
        Vector3 nextPos = transform.position;


        if (Input.GetMouseButtonDown(0))
        {
            _initialMousePos = Input.mousePosition.x / Screen.width * 2f - 1f;
        }
        else if (Input.GetMouseButton(0))
        {
            float delta = ((Input.mousePosition.x / Screen.width * 2f - 1f) - _initialMousePos) * 0.5f;
            _force += delta;

            _useForce = true;
        }

        if (_force < 0f)
        {
            _force = _force - _force * _brake * Time.deltaTime;

            if (_force + 0.01f > 0f)
            {
                _force = 0f;
                _useForce = false;
            }
        }
        else if (_force > 0f)
        {
            _force = _force - _force * _brake * Time.deltaTime;

            if (_force - 0.01f < 0f)
            {
                _force = 0f;
                _useForce = false;
            }
        }

        if (_useForce)
        {
            float f = 0f;

            if (_force < 0f)
                f = -19.2f;
            else if (_force > 0f)
                f = 19.2f;

            nextPos = Vector3.MoveTowards(transform.position, new Vector3(f, 0f, -10f), _moveSpeed * Time.deltaTime);
            nextPos.x = Mathf.Clamp(nextPos.x, -19.2f, 19.2f);
            transform.position = nextPos;

            if (transform.position.x != _lastXPosition)
            {
                float delta = _lastXPosition - transform.position.x;

                for (int i = 0; i < _parallaxLayers.Length; i++)
                {
                    Transform obj = _parallaxLayers[i].Layer;
                    obj.position -= new Vector3(_parallaxLayers[i].Distance * delta / 1000f, 0, 0);
                }

                _lastXPosition = transform.position.x;
            }
        }
    }
}



[System.Serializable]
internal class ParallaxLayer
{
    [SerializeField]
    private Transform _layer;
    [SerializeField]
    private float _distance;



    public float Distance
    {
        get { return _distance; }
    }

    public Transform Layer
    {
        get { return _layer; }
    }
}