using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero : Character
{
    public HeroLevel[] heroLevels;



    public Hero()
    {
        this.heroLevels = new HeroLevel[Balance.CardLevels];
        
        for(int i = 0; i < this.heroLevels.Length; i++)
        {
            this.heroLevels[i] = new HeroLevel();
        }
    }
}
