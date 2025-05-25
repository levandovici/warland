using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    [Header("UI Panels")]

    [SerializeField]
    private ResourcesUIPanel _resources;

    [SerializeField]
    private MyProfileUIPanel _myProfile;

    [SerializeField]
    private MapUIPanel _map;

    [SerializeField]
    private DeckUIPanel _deck;

    [SerializeField]
    private CardUIPanel _card;

    [SerializeField]
    private ClanUIPanel _clan;

    [SerializeField]
    private ShopUIPanel _shop;

    [SerializeField]
    private MainSettingsUIPanel _settings;

    [SerializeField]
    private TasksUIPanel _tasks;

    [SerializeField]
    private LeaderboardsUIPanel _leaderboards;

    [SerializeField]
    private PlayUIPanel _play;

    [SerializeField]
    private ClanProfileUIPanel _clanProfile;

    [SerializeField]
    private PlayerProfileUIPanel _playerProfile;


    [Header("Buttons")]

    [SerializeField]
    private Button _profileButton;

    [SerializeField]
    private Button _settingsButton;

    [SerializeField]
    private Button _mapButton;

    [SerializeField]
    private Button _deckButton;

    [SerializeField]
    private Button _shopButton;

    [SerializeField]
    private Button _tasksButton;

    [SerializeField]
    private Button _playButton;


    [Header("Other")]

    [SerializeField]
    private EPanel _current = EPanel.None;



    public ResourcesUIPanel Resources
    {
        get
        {
            return _resources;
        }
    }

    public MyProfileUIPanel MyProfile
    {
        get
        {
            return _myProfile;
        }
    }

    public MapUIPanel Map
    {
        get
        {
            return _map;
        }
    }

    public DeckUIPanel Deck
    {
        get
        {
            return _deck;
        }
    }

    public CardUIPanel Card
    {
        get
        {
            return _card;
        }
    }

    public ClanUIPanel Clan
    {
        get
        {
            return _clan;
        }
    }

    public ShopUIPanel Shop
    {
        get
        {
            return _shop;
        }
    }

    public MainSettingsUIPanel Settings
    {
        get
        {
            return _settings;
        }
    }

    public TasksUIPanel Tasks
    {
        get
        {
            return _tasks;
        }
    }

    public LeaderboardsUIPanel Leaderboards
    {
        get
        {
            return _leaderboards;
        }
    }

    public PlayUIPanel Play
    {
        get
        {
            return _play;
        }
    }

    public ClanProfileUIPanel ClanProfile
    {
        get
        {
            return _clanProfile;
        }
    }

    public PlayerProfileUIPanel PlayerProfile
    {
        get
        {
            return _playerProfile;
        }
    }



    public EPanel Current
    {
        get
        {
            return _current;
        }

        set
        {
            Change(value, _current);

            _current = value;
        }
    }



    private void Awake()
    {
        Setup();

        _profileButton.onClick.AddListener(OpenProfile);

        _settingsButton.onClick.AddListener(OpenSettings);

        _mapButton.onClick.AddListener(OpenMap);

        _deckButton.onClick.AddListener(OpenDeck);

        _shopButton.onClick.AddListener(OpenShop);

        _tasksButton.onClick.AddListener(OpenTasks);

        _playButton.onClick.AddListener(OpenPlay);
    }



    private void Setup()
    {
        Open(EPanel.Map);

        Close(EPanel.MyProfile);

        Close(EPanel.Deck);

        Close(EPanel.Card);

        Close(EPanel.Clan);

        Close(EPanel.Shop);

        Close(EPanel.Settings);

        Close(EPanel.Tasks);

        Close(EPanel.Leaderboard);

        Close(EPanel.Play);

        Close(EPanel.ClanProfile);

        Close(EPanel.PlayerProfile);

        _current = EPanel.Map;
    }



    private void OpenProfile()
    {
        Change(EPanel.MyProfile, Current);
    }

    private void OpenSettings()
    {
        Change(EPanel.Settings, Current);
    }

    private void OpenMap()
    {
        Change(EPanel.Map, Current);
    }

    private void OpenDeck()
    {
        Change(EPanel.Deck, Current);
    }

    private void OpenShop()
    {
        Change(EPanel.Shop, Current);
    }

    private void OpenTasks()
    {
        Change(EPanel.Tasks, Current);
    }

    private void OpenPlay()
    {
        Change(EPanel.Play, Current);
    }



    private void Change(EPanel open, EPanel close)
    {
        if (open == close && _current == open)
            return;

        Close(close);

        Open(open);

        _current = open;
    }

    private void Open(EPanel panel)
    {
        switch (panel)
        {
            case EPanel.MyProfile:
                _myProfile.Open();
                break;

            case EPanel.Map:
                _map.Open();
                break;

            case EPanel.Deck:
                _deck.Open();
                break;

            case EPanel.Card:
                _card.Open();
                break;

            case EPanel.Clan:
                _clan.Open();
                break;

            case EPanel.Shop:
                _shop.Open();
                break;

            case EPanel.Settings:
                _settings.Open();
                break;

            case EPanel.Tasks:
                _tasks.Open();
                break;

            case EPanel.Leaderboard:
                _leaderboards.Open();
                break;

            case EPanel.Play:
                _play.Open();
                break;

            case EPanel.ClanProfile:
                _clanProfile.Open();
                break;

            case EPanel.PlayerProfile:
                _playerProfile.Open();
                break;

            default:
                Debug.LogWarning("This window is not setuped!");
                break;
        }
    }

    private void Close(EPanel close)
    {
        switch(close)
        {
            case EPanel.MyProfile:
                _myProfile.Close();
                break;

            case EPanel.Map:
                _map.Close();
                break;

            case EPanel.Deck:
                _deck.Close();
                break;

            case EPanel.Card:
                _card.Close();
                break;

            case EPanel.Clan:
                _clan.Close();
                break;

            case EPanel.Shop:
                _shop.Close();
                break;

            case EPanel.Settings:
                _settings.Close();
                break;

            case EPanel.Tasks:
                _tasks.Close();
                break;

            case EPanel.Leaderboard:
                _leaderboards.Close();
                break;

            case EPanel.Play:
                _play.Close();
                break;

            case EPanel.ClanProfile:
                _clanProfile.Close();
                break;

            case EPanel.PlayerProfile:
                _playerProfile.Close();
                break;

            default:
                Debug.LogWarning("This window is not setuped!");
                break;
        }
    }



    public enum EPanel
    {
        None, MyProfile, Map, Deck, Card, Clan, Shop, Settings, 
        Tasks, Leaderboard, Play, ClanProfile, PlayerProfile,
    }
}
