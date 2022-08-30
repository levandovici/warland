using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    public void Show()
    {
        SetActive(true);
    }

    public void Hide()
    {
        SetActive(false);
    }

    private void SetActive(bool activ)
    {
        this.gameObject.SetActive(activ);
    }
}
