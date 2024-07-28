using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Map
{
    [SerializeField]
    private Level[] _levels;



    public int LevelsCount
    {
        get
        {
            return _levels.Length;
        }
    }



    public Level GetLevel(int index)
    {
        if (index < 0 || index >= LevelsCount)
            return null;

        return _levels[index];
    }



    public Map()
    {
        _levels = new Level[5];

        for(int i = 0; i < _levels.Length; i++)
        {
            _levels[i] = new Level();
        }
    }
}
