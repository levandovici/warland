using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyProfileUIPanel : UIPanel
{
    [SerializeField]
    private Button _myProfile;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Text _tag;

    [SerializeField]
    private Text _towerLevel;

    [SerializeField]
    private Button _clanFlag;

    [SerializeField]
    private Text _clanName;

    [SerializeField]
    private Button _openClan;

    [SerializeField]
    private Text _stars;

    [SerializeField]
    private AchievementUIItem[] _achievements;



    [SerializeField]
    private Button _friends;
}
