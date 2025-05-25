using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayUIPanel : UIPanel
{
    [SerializeField]
    private Button _background;

    [SerializeField]
    private Button _close;

    [SerializeField]
    private Button _play;



    public event Action OnCloseClicked;

    public event Action OnPlayClicked;



    private void Awake()
    {
        _background.onClick.AddListener(OnCloseEvent);

        _close.onClick.AddListener(OnCloseEvent);

        _play.onClick.AddListener(OnPlayEvent);
    }



    private void OnCloseEvent()
    {
        OnCloseClicked?.Invoke();
    }

    private void OnPlayEvent()
    {
        OnPlayClicked?.Invoke();
    }
}
