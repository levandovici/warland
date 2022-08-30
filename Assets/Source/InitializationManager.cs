using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializationManager : MonoBehaviour
{
    [SerializeField]
    private SceneLoader _sceneLoader = null;

    [SerializeField]
    private Image[] _backgrounds;



    private void Awake()
    {
        SaveLoadManager.Initialize();
        SaveLoadManager.Load();

        SetUpBackground(SaveLoadManager.Current.map_info.GetLastPassedMapID());
        _sceneLoader.SetUp(SaveLoadManager.CurrentSessionData.LoadSceneID);
    }

    private void Start()
    {
        _sceneLoader.Load();
    }

    private void SetUpBackground(int id)
    {
        for(int i = 0; i < _backgrounds.Length; i++)
        {
            _backgrounds[i].gameObject.SetActive(id == i);
        }
    }
}
