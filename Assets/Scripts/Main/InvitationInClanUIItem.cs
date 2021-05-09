using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InvitationInClanUIItem : UIItemWithOptions
{
    [SerializeField]
    private Text _position;

    [SerializeField]
    private Text _name;

    [SerializeField]
    private Text _starsCount;

    [SerializeField]
    private Text _clanLockType;

    [SerializeField]
    private Text _clanPlayersCount;

    ///OPTIONS///

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



    public event Action OnClanButtonClicked;

    public event Action OnAcceptButtonClicked;

    public event Action OnDeleteButtonClicked;



    public new void Awake()
    {
        base.Awake();

        _clanButton.onClick.AddListener(() => OnClanButtonClicked.Invoke());

        _acceptButton.onClick.AddListener(() => OnAcceptButtonClicked.Invoke());

        _deleteButton.onClick.AddListener(() => OnDeleteButtonClicked.Invoke());
    }



    public void SetUp(int position, string name, int starsCount, string clanLockType, int playersCount, int max,
        string clanText, string acceptText, string deleteText)
    {
        _position.text = $"{position}";

        _name.text = name;

        _starsCount.text = $"{starsCount}";

        _clanLockType.text = clanLockType;

        SetUpClanPlayersCount(playersCount, max);

        _clanText.text = clanText;

        _acceptText.text = acceptText;

        _deleteText.text = deleteText;
    }

    public void SetUpClanPlayersCount(int playersCount, int max)
    {
        _clanPlayersCount.text = $"{playersCount}/{max}";
    }
}
