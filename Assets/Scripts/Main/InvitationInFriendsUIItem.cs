using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InvitationInFriendsUIItem : UIItemWithOptions
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
    private Button _acceptButton;

    [SerializeField]
    private Text _acceptText;

    [SerializeField]
    private Button _deleteButton;

    [SerializeField]
    private Text _deleteText;



    public event Action OnProfileButtonClicked;

    public event Action OnClanButtonClicked;

    public event Action OnAcceptButtonClicked;

    public event Action OnDeleteButtonClicked;



    public new void Awake()
    {
        base.Awake();

        _profileButton.onClick.AddListener(() => OnProfileButtonClicked.Invoke());

        _clanButton.onClick.AddListener(() => OnClanButtonClicked.Invoke());

        _acceptButton.onClick.AddListener(() => OnAcceptButtonClicked.Invoke());

        _deleteButton.onClick.AddListener(() => OnDeleteButtonClicked.Invoke());
    }

    public void SetUp(int position, string name, string clanStare, int starsCount, string towerLevel,
        string profileText, string clanText, string acceptText, string deleteText)
    {
        _position.text = $"{position}";

        _name.text = name;

        _clanState.text = clanStare;

        _starsCount.text = $"{starsCount}";

        _towerLevel.text = towerLevel;

        _profileText.text = profileText;

        _clanText.text = clanText;

        _acceptText.text = acceptText;

        _deleteText.text = deleteText;
    }
}
