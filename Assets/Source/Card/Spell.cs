using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell : Card
{
    public SpellLevel[] spellLevels;



    public Spell()
    {
        this.spellLevels = new SpellLevel[Balance.CardLevels];

        for (int i = 0; i < this.spellLevels.Length; i++)
        {
            this.spellLevels[i] = new SpellLevel();
        }
    }
}
