using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell : Card
{
    public Spell()
    {
        this.cardLevels = new SpellLevel[12];

        for (int i = 0; i < this.cardLevels.Length; i++)
        {
            this.cardLevels[i] = new SpellLevel();
        }
    }
}
