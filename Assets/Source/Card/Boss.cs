using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boss : Character
{
    public BossLevel[] bossLevels;



    public Boss()
    {
        this.bossLevels = new BossLevel[Balance.CardLevels];

        for (int i = 0; i < this.bossLevels.Length; i++)
        {
            this.bossLevels[i] = new BossLevel();
        }
    }
}
