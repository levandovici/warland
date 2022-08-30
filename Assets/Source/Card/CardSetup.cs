using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardSetup : ScriptableObject
{
    public GameObject cardPrefab;

    public Sprite cardSprite;

    public int openLevel;
}
