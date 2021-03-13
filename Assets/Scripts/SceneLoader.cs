using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private int _loadSceneID = 1;

    [SerializeField]
    private bool _loadOnStart = false;

    [SerializeField]
    private float _waitTime  = 0f;

    [SerializeField]
    private Slider _progressBar = null;

    [SerializeField]
    private Text _progressText = null;



    private void Start()
    {
        if(_loadOnStart)
        {
            Load();
        }
    }



    public void SetUp(int loadSceneID, float waitTime = 0f)
    {
        _loadSceneID = loadSceneID;
    }

    public void Load()
    {
        StartCoroutine(LoadScene(_loadSceneID, _waitTime));
    }

    public void Load(int loadSceneID, float waitTime = 0f)
    {
        SetUp(loadSceneID, waitTime);
        Load();
    }

    private IEnumerator LoadScene(int id, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        float progress = 0f;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(id);

        while (!asyncOperation.isDone)
        {
            if (progress < asyncOperation.progress)
                progress = asyncOperation.progress;

            if(_progressBar != null)
            _progressBar.value = progress;

            if(_progressText != null)
            _progressText.text = $"{(int)(progress * 100f)}%";

            yield return null;
        }
    }
}