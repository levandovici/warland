using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveLoadController
{
    public string LoadData(string path);

    public void SaveData(string path, string data);
}
