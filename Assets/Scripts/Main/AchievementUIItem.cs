using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUIItem : UIItem
{
    [SerializeField]
    private Text _position;

    [SerializeField]
    private Text _achievement;

    [SerializeField]
    private Text _progress;

    [SerializeField]
    private GameObject _star_first;

    [SerializeField]
    private GameObject _star_second;

    [SerializeField]
    private GameObject _star_third;
}
