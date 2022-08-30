using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class SimpleSaveLoadController : ISaveLoadController
{
    public string LoadData(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else return null;
        }
        catch(Exception e)
        {
            throw new NotImplementedException();
        }
    }

    public void SaveData(string path, string data)
    {
        try
        {
            File.WriteAllText(path, data);
        }
        catch (Exception e)
        {
            throw new NotImplementedException();
        }
    }
}
