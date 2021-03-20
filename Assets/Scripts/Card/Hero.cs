using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero : Character
{
    public Hero()
    {
        this.cardLevels = new HeroLevel[12];
        
        for(int i = 0; i < this.cardLevels.Length; i++)
        {
            this.cardLevels[i] = new HeroLevel();
        }
    }
}
