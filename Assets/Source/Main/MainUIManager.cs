using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainUIManager : MonoBehaviour
{
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

    [SerializeField]
    private EPanel _current = EPanel.None;



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



    private void Change(EPanel open, EPanel close)
    {
        Open(open);

        Close(close);
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
