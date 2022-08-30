using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FriendUIItem : UIItemWithOptions
{
    [SerializeField]
    private Text _position;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Text _clanState;

    [SerializeField]
    private Text _starsCount;

    [SerializeField]
    private Text _towerLevel;

    ///OPTIONS///

    [SerializeField]
    private Button _profileButton;

    [SerializeField]
    private Text _profileText;

    [SerializeField]
    private Button _clanButton;

    [SerializeField]
    private Text _clanText;

    [SerializeField]
    private Button _inviteInClanButton;

    [SerializeField]
    private Text _inviteInClanText;

    [SerializeField]
    private Button _deleteButton;

    [SerializeField]
    private Text _deleteText;



    public event Action OnProfileButtonClicked;

    public event Action OnClanButtonClicked;

    public event Action OnInviteInClanButtonClicked;

    public event Action OnDeleteButtonClicked;



    public new void Awake()
    {
        base.Awake();

        _profileButton.onClick.AddListener(() => OnProfileButtonClicked.Invoke());

        _clanButton.onClick.AddListener(() => OnClanButtonClicked.Invoke());

        _inviteInClanButton.onClick.AddListener(() => OnInviteInClanButtonClicked.Invoke());

        _deleteButton.onClick.AddListener(() => OnDeleteButtonClicked.Invoke());
    }



    public void SetUp(int position, string name, string clanState, int starsCount, string towerLevel,
        string profileText, string clanText, string inviteInClanText, string deleteText)
    {
        _position.text = $"{position}";

        _name.text = name;

        _clanState.text = clanState;

        _starsCount.text = $"{starsCount}";

        _towerLevel.text = towerLevel;

        _profileText.text = profileText;

        _clanText.text = clanText;

        _inviteInClanText.text = inviteInClanText;

        _deleteText.text = deleteText;
    }
}
