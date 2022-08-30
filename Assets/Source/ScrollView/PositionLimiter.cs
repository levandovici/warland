using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLimiter : MonoBehaviour
{
    [SerializeField]
    private float _minPosition;

    [SerializeField]
    private float _maxPosition;

    [SerializeField]
    private bool _limitXnoY = false;



    private void Update()
    {
        if (_limitXnoY)
        {
            if (transform.localPosition.x < _minPosition)
            {
                transform.localPosition = new Vector2(_minPosition, transform.localPosition.y);
            }
            else if (transform.localPosition.x > _maxPosition)
            {
                transform.localPosition = new Vector2(_maxPosition, transform.localPosition.y);
            }
        }
        else
        {
            if (transform.localPosition.y < _minPosition)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, _minPosition);
            }
            else if (transform.localPosition.y > _maxPosition)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, _maxPosition);
            }
        }
    }



    public void SetUp(float maxPosition, float minPosition = 0f, bool limitXnoY = false)
    {
        _minPosition = minPosition;

        _maxPosition = maxPosition;

        _limitXnoY = limitXnoY;
    }
}
