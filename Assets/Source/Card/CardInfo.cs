using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardInfo
{
    [SerializeField]
    private bool _isBought = false;

    [SerializeField]
    private int _level = 1;



    public CardInfo(bool isBought = false, int level = 1)
    {
        this._isBought = isBought;
        this._level = level;
    }
}
