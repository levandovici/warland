using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character : Card
{
    public EAttack attack;
    public ETarget target;
    public EWeapon weapon;
    public EDamage damage;
    public EDeffense deffense;

    public float coolDown = 0f;
    public float range = 0f;
}
