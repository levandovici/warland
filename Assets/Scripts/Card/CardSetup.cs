using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card", order = 1)]
public class CardSetup : ScriptableObject
{
    public ECardType cardType;

    public Card card;

    public CardObject cardObject;

    public Sprite cardSprite;

    public int openLevel;
}

public enum ECardType
{
    hero, boss, spell
}
