using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public CardLevel[] cardLevels;



    public Card()
    {
        this.cardLevels = new CardLevel[12];

        for(int i = 0; i < this.cardLevels.Length; i++)
        {
            this.cardLevels[i] = new CardLevel();
        }
    }
}
