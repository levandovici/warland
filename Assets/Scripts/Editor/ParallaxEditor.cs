using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Parallax))]
public class ParallaxEditor : Editor
{
    private Parallax _target = null;

    public override void OnInspectorGUI()
    {
       base.OnInspectorGUI();

        if (_target == null)
            _target = (Parallax)target;

        if (GUILayout.Button("Flip Layers Random"))
        {
            _target.FlipLayersRandom();
        }
    }
}
