using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SessionData
{
    private int _loadSceneID;



    public int LoadSceneID => _loadSceneID;



    public void SetUp(int loadSceneID)
    {
        _loadSceneID = loadSceneID;
    }
}
