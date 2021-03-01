using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [Header("Parallax Objects")]
    [SerializeField]
    private ParallaxLayer[] _parallaxLayers;

    private float _lastXPosition = 0f;



    public void FlipLayersRandom()
    {
        Transform parent = null;
        SpriteRenderer[] children = null;

        for(int i = 0; i < _parallaxLayers.Length; i++)
        {
            parent = _parallaxLayers[i].Layer;
            children = parent.GetComponentsInChildren<SpriteRenderer>(true);
            
            for(int j = 0; j < children.Length; j++)
            {
                children[j].flipX = UnityEngine.Random.Range(0, 2) == 0;
            }
        }
    }



    private void LateUpdate()
    {
        if (transform.position.x != _lastXPosition)
        {
            float delta = _lastXPosition - transform.position.x;


            for (int i = 0; i < _parallaxLayers.Length; i++)
            {
                Transform obj = _parallaxLayers[i].Layer;
                obj.position -= new Vector3(_parallaxLayers[i].Distance * delta / 1000f, 0, 0);
            }


            _lastXPosition = transform.position.x;
        }
    }
}



[System.Serializable]
internal class ParallaxLayer
{
    [SerializeField]
    private Transform _layer;
    [SerializeField]
    private float _distance;



    public float Distance
    {
        get { return _distance; }
    }

    public Transform Layer
    {
        get { return _layer; }
    }
}