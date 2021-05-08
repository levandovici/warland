using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemWithOptions : UIItem
{
    [SerializeField]
    private Button _optionsButton;

    [SerializeField]
    private GameObject _optionsPanel;

    private bool _optionsOpened = false;



    public void Awake()
    {
        _optionsButton.onClick.AddListener(() =>
        {
            if (_optionsOpened)
            {
                _optionsOpened = !_optionsOpened;
                _optionsPanel.SetActive(_optionsOpened);
            }
        });
    }
}
