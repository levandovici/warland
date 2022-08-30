using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class CharacterLevel
{
    public float health;
    public float damage;

    public UpgradePrice upgradePrice;
}

[Flags]
public enum EAttack
{
    none = 0, forward = 1, left_right = 2, backward = 4,
}

public enum ETarget
{
   none = 0, enemy = 1, tower = 2,
}

public enum EWeapon
{
    none = 0, knife = 1, axe = 2, hammer = 4, sword = 8, bow = 16,
}

public enum EDamage
{
    none = 0, one = 1, multiply_one = 2, multiply_more = 4, spash = 8,
}

public enum EDeffense
{
    none = 0, shield = 1, push_forward = 2, push_left_right = 4, push_forward_left_right = 8,
}