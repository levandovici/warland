using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    public void Open()
    {
        SetActive(true);
    }

    public void Close()
    {
        SetActive(false);
    }

    private void SetActive(bool activ)
    {
        this.gameObject.SetActive(activ);
    }
}
