using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapInfo
{
    public Map[] maps;



    public bool IsMapPassed(int id)
    {
        return maps[id].levels[maps[id].levels.Length - 1].passed;
    }

    public int GetLastPassedMapID()
    {
        for(int i = 0; i < maps.Length; i++)
        {
            if(!IsMapPassed(i))
            {
                return Math.Max(i - 1, 0);
            }
        }

        return maps.Length - 1;
    }



    public MapInfo()
    {
        maps = new Map[12];

        for(int i = 0; i < maps.Length; i++)
        {
            maps[i] = new Map();
        }
    }
}
