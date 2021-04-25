using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct Gift
{
    
}

[Flags]
public enum EGift
{
    none = 0, gold = 1, diamonds = 2, keys = 4, hero = 8, boss = 16, spell = 32, tower_upgrade,
}
