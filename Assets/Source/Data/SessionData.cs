using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionData
{
    private int _loadSceneID;



    public int LoadSceneID => _loadSceneID;

    public ESessionDataLoadScene SessionDataLoadScene => (ESessionDataLoadScene)_loadSceneID;



    public void SetUp(ESessionDataLoadScene sessionDataLoadScene)
    {
        _loadSceneID = (int)sessionDataLoadScene;
    }



    public SessionData(ESessionDataLoadScene sessionDataLoadScene)
    {
        _loadSceneID = (int)sessionDataLoadScene;
    }
}

public enum ESessionDataLoadScene
{
    logo = 0, loading = 1, main = 2, 
}
