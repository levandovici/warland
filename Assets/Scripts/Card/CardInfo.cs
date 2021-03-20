using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo
{
    public bool isBought = false;
    public int level = 1;



    public CardInfo(bool isBought = false, int level = 1)
    {
        this.isBought = isBought;
        this.level = level;
    }
}
