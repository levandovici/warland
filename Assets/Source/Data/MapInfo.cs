using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MapInfo
{
    [SerializeField]
    private Map[] _maps;



    public bool IsMapPassed(int id)
    {
        return _maps[id].GetLevel(_maps[id].LevelsCount - 1).IsPassed;
    }

    public int GetLastPassedMapID()
    {
        for(int i = 0; i < _maps.Length; i++)
        {
            if(!IsMapPassed(i))
            {
                return Math.Max(i - 1, 0);
            }
        }

        return _maps.Length - 1;
    }



    public MapInfo()
    {
        _maps = new Map[12];

        for(int i = 0; i < _maps.Length; i++)
        {
            _maps[i] = new Map();
        }
    }
}
