using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemWithOptions : UIItem
{
    [SerializeField]
    private Button _optionsButton;

    [SerializeField]
    private GameObject _options;

    private bool _optionsOpened = false;



    private void Awake()
    {
        _optionsButton.onClick.AddListener(() =>
        {
            if (_optionsOpened)
            {
                _optionsOpened = !_optionsOpened;
                _options.SetActive(_optionsOpened);
            }
        });
    }
}
