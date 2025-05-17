using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyProfileUIPanel : UIPanel
{
    #region Fields 

    #region Main Buttons

    [Header("Main Buttons")]

    [SerializeField]
    private Button _myProfileButton;

    [SerializeField]
    private Text _myProfileText;

    [SerializeField]
    private Button _friendsButton;

    [SerializeField]
    private Text _friendsText;

    #endregion

    #region My Profile

    [Header("My Profile")]

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
    private Text _openText;

    [SerializeField]
    private Text _stars;

    [SerializeField]
    private Text _achievementsText;

    [SerializeField]
    private RectTransform _achievementsContent;

    [SerializeField]
    private AchievementUIItem[] _achievements;

    #endregion

    #region Friends Buttons

    [Header("Friends Buttons")]

    [SerializeField]
    private Button _friendsFriendsButton;

    [SerializeField]
    private Text _friendsFriendsButtonText;

    [SerializeField]
    private Button _friendsInvitationsButton;

    [SerializeField]
    private Text _friendsInvitationsText;

    [SerializeField]
    private Button _friendsSearchButton;

    [SerializeField]
    private Text _friendsSearchButtonText;

    #endregion

    #region Friends List

    [Header("Friends List")]

    [SerializeField]
    private Text _friendsFriendsText;

    [SerializeField]
    private RectTransform _friendsFriendsContent;

    [SerializeField]
    private FriendUIItem[] _friendsFriends;

    #endregion

    #region Invitations List

    [Header("Invitations List")]

    [SerializeField]
    private Text _myInvitationsText;

    [SerializeField]
    private Text _invitationsText;

    [SerializeField]
    private Text _invitationsInClanText;

    [SerializeField]
    private RectTransform _myInvitationsInFriendsContent;

    [SerializeField]
    private MyInvitationInFriendsUIItem[] _myInvitationsInFriends;

    [SerializeField]
    private RectTransform _invitationsInFriendsContent;

    [SerializeField]
    private InvitationInFriendsUIItem[] _invitationsInFriends;

    [SerializeField]
    private RectTransform _invitationsInClanContent;

    [SerializeField]
    private InvitationInClanUIItem[] _invitationsInClan;

    #endregion

    #region Search List

    [Header("Search List")]

    [SerializeField]
    private Text _friendsSearchText;

    [SerializeField]
    private InputField _friendsSearchInputField;

    [SerializeField]
    private Button _searchButton;

    [SerializeField]
    private Text _searchText;

    [SerializeField]
    private RectTransform _searchFriendsContent;

    [SerializeField]
    private SearchFriendUIItem[] _searchFriends;

    #endregion

    #endregion



    #region Events

    public event Action OnMyProfileClicked;

    public event Action OnFriendsClicked;


    public event Action OnClanFlagClicked;

    public event Action OnOpenClanClicked;


    public event Action OnFriendsListClicked;

    public event Action OnInvitationsListClicked;

    public event Action OnSearchListClicked;


    public event Action OnSearchClicked;

    #endregion



    #region Properties



    #endregion
}
