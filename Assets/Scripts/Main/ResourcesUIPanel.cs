using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResourcesUIPanel : UIPanel
{
    [SerializeField]
    private Text _diamonds;

    [SerializeField]
    private Text _gold;

    [SerializeField]
    private Text _stars;

    [SerializeField]
    private GameObject _keysPanel;

    [SerializeField]
    private Text _keys;

    [SerializeField]
    private GameObject _keysLoadingPanel;

    [SerializeField]
    private Text _keysLoading;

    [SerializeField]
    private Text _keysLoadingRemainingTime;



    public void SetUp(int diamonds, int gold, int stars, bool isKeyLoading, int keys, int maxKeys, TimeSpan keyLoadingRemainingTime)
    {
        _diamonds.text = diamonds.ToString("# ### ### ### ### ##0");

        _gold.text = gold.ToString("# ### ### ### ### ##0");

        _stars.text = stars.ToString("# ### ### ### ### ##0");

        SetUpKeys(isKeyLoading, keys, maxKeys, keyLoadingRemainingTime);
    }

    public void SetUpKeys(bool isKeyLoading, int keys, int maxKeys, TimeSpan keyLoadingRemainingTime)
    {
        _keysPanel.SetActive(!isKeyLoading);
        _keysLoadingPanel.SetActive(isKeyLoading);

        if (isKeyLoading)
        {
            _keysLoading.text = $"{keys}/{maxKeys}";
            _keysLoadingRemainingTime.text = keyLoadingRemainingTime.ToString();
        }
        else
        {
            _keys.text = $"{keys}/{maxKeys}";
        }
    }
}