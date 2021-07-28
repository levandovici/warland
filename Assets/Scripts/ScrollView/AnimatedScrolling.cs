using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedScrolling : MonoBehaviour
{
    [SerializeField][Header("Test")]
    private int _elementsCount;

    [SerializeField]
    private GameObject _elementPrefab;

    [SerializeField]
    private bool _testing = false;

    [SerializeField]
    [Header("Controllers")]
    private int _elementsOffset;

    [SerializeField]
    private int _selectedElementID = 0;

    private bool _isScrolling = false;

    [SerializeField]
    private float _scrollingSpeed;

    [SerializeField]
    private float _scaleSpeed;

    [SerializeField]
    private float _scaleOffest;

    [SerializeField]
    private float _minInertia = 400f;

    [SerializeField]
    private ScrollRect _scrollRect;

    [SerializeField]
    private Transform _content;

    [SerializeField]
    private GameObject[] _elements = null;



    private void Start()
    {
        if (_testing)
        {
            _elements = new GameObject[_elementsCount];

            for (int i = 0; i < _elementsCount; i++)
            {
                _elements[i] = Instantiate(_elementPrefab, _content, false);

                _elements[i].transform.localPosition =
                     new Vector2(0f, (((RectTransform)_elementPrefab.transform).sizeDelta.y + _elementsOffset) * -i);
            }
        }
    }

    private void Update()
    {
        if(((RectTransform)_content).anchoredPosition.y <= -_elements[0].transform.localPosition.y ||
            ((RectTransform)_content).anchoredPosition.y >= -_elements[_elements.Length - 1].transform.localPosition.y)
        {
            if (!_isScrolling)
            {
                _scrollRect.inertia = false;
            }
        }

        float nearestPos = Mathf.Infinity;

        for(int i = 0; i < _elements.Length; i++)
        {
            float distance = Mathf.Abs(((RectTransform)_content).anchoredPosition.y + _elements[i].transform.localPosition.y);

            if(distance < nearestPos)
            {
                nearestPos = distance;
                _selectedElementID = i;
            }


            float scale = Mathf.Clamp(1f / (distance) * _scaleOffest, 0.5f, 1f);

            Vector2 elementScale = Vector2.zero;

            elementScale.x = Mathf.SmoothStep(_elements[i].transform.localScale.x, scale, _scaleSpeed * Time.deltaTime);
            elementScale.y = Mathf.SmoothStep(_elements[i].transform.localScale.y, scale, _scaleSpeed * Time.deltaTime);

            _elements[i].transform.localScale = elementScale;
        }

        float scrollVelecity = Mathf.Abs(_scrollRect.velocity.y);

        if(!_isScrolling && scrollVelecity < _minInertia)
        {
                _scrollRect.inertia = false;
        }

        if (!_isScrolling || scrollVelecity <= _minInertia)
        {
            Vector2 contentPosition = new Vector2(0f, 0f);

            contentPosition.y = Mathf.SmoothStep(((RectTransform)_content).anchoredPosition.y,
                -_elements[_selectedElementID].transform.localPosition.y, _scrollingSpeed * Time.deltaTime);

            ((RectTransform)_content).anchoredPosition = contentPosition;
        }
    }

    public void SetUpScrolling(bool isScrolling)
    {
        _isScrolling = isScrolling;

        if (_isScrolling)
            _scrollRect.inertia = true;
    }
}
