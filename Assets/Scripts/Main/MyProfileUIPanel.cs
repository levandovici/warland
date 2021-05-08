using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyProfileUIPanel : UIPanel
{
    [SerializeField]
    private Button _myProfileButton;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Text _tag;

    [SerializeField]
    private Text _towerLevel;

    [SerializeField]
    private Button _clanFlagButton;

    [SerializeField]
    private Text _clanName;

    [SerializeField]
    private Button _openClanButton;

    [SerializeField]
    private Text _stars;

    [SerializeField]
    private AchievementUIItem[] _achievements;



    [SerializeField]
    private Button _friendsButton;

    [SerializeField]
    private Button _friendsFriendsButton;

    [SerializeField]
    private Button _friendsInvitationsButton;

    [SerializeField]
    private Button _friendsSearchButton;
}
