using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public static class SaveLoadManager
{
    private static string PATH = "PlayerData";

    private static string GetPath
    {
        get
        {
#if UNITY_ANDROID
            return Path.Combine(Application.persistentDataPath, PATH);
#else
            return Path.Combine(Application.dataPath, PATH);
#endif
        }
    }



    private static PlayerData _current = null;

    private static SessionData _currentSessionData = null;

    private static ISaveLoadController _saveLoadController = new SimpleSaveLoadController();



    public static PlayerData Current
    {
        get
        {
            if (_current == null)
            {
                Load();
            }
            return _current;
        }
    }

    public static SessionData CurrentSessionData => _currentSessionData;



    public static void Initialize()
    {
        if (_currentSessionData != null)
            return;

        _currentSessionData = new SessionData(ESessionDataLoadScene.main);
    }

    public static void Load()
    {
        try
        {
            string data = _saveLoadController.LoadData(GetPath);

            if (data != null)
            {
                _current = JsonUtility.FromJson<PlayerData>(data);
            }
            else
            {
                _current = new PlayerData();
            }
        }
        catch(Exception e)
        {
            throw new NotImplementedException();
        }
    }

    public static void Save()
    {
        try
        {
            string data = JsonUtility.ToJson(_current);
            _saveLoadController.SaveData(GetPath, data);
        }
        catch(Exception e)
        {
            throw new NotImplementedException();
        }
    }
}
