using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public Level[] levels;



    public Map()
    {
        levels = new Level[5];

        for(int i = 0; i < levels.Length; i++)
        {
            levels[i] = new Level();
        }
    }
}
