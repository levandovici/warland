using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class DeckInfo
{
    public int heroID_1;
    public int heroID_2;
    public int heroID_3;

    public int bossID_1;
    [Obsolete("deprecated", false)]
    public int bossID_2;

    public int spellID_1;


    [Obsolete("[deprecated]", false)]
    public DeckInfo(int heroID_1, int heroID_2, int heroID_3, int bossID_1, int bossID_2, int spellID_1 = -1)
    {
        this.heroID_1 = heroID_1;
        this.heroID_2 = heroID_2;
        this.heroID_3 = heroID_3;

        this.bossID_1 = bossID_1;
        this.bossID_2 = bossID_2;

        this.spellID_1 = spellID_1;
    }

    public DeckInfo(int heroID_1, int heroID_2, int heroID_3, int bossID_1, int spellID_1)
    {
        this.heroID_1 = heroID_1;
        this.heroID_2 = heroID_2;
        this.heroID_3 = heroID_3;

        this.bossID_1 = bossID_1;

        this.spellID_1 = spellID_1;
    }
}
