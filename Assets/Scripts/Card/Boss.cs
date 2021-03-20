using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boss : Character
{
    public Boss()
    {
        this.cardLevels = new BossLevel[12];

        for (int i = 0; i < this.cardLevels.Length; i++)
        {
            this.cardLevels[i] = new BossLevel();
        }
    }
}
