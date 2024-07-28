using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerData
{
    [SerializeField]
    private string _guid;

    [SerializeField]
    private string _name;

    [SerializeField]
    private HeroInfo[] _heroes_info;

    [SerializeField]
    private BossInfo[] _bosses_info;

    [SerializeField]
    private SpellInfo[] _spells_info;

    [SerializeField]
    private MapInfo _map_info;

    [SerializeField]
    private SystemLanguage _language;

    [SerializeField]
    private int _gold;

    [SerializeField]
    private int _diamonds;

    [SerializeField]
    private int _stars;

    [SerializeField]
    private int _wins;

    [SerializeField]
    private int _played_games;

    [SerializeField]
    private int _total_gold;

    [SerializeField]
    private int _total_diamonds;

    [SerializeField]
    private int _total_stars;

    [SerializeField]
    private AchievementInfo[] _achievementsInfo;

    [SerializeField]
    private int _towerLevel;

    [SerializeField]
    private int _keys;

    [SerializeField]
    private DeckInfo _deckInfo;

    [SerializeField]
    private float _sfx_volume;

    [SerializeField]
    private float _music_volume;

    [SerializeField]
    private float _spent_money;

    [SerializeField]
    private bool _is_infinity_keys;

    [SerializeField]
    private bool _is_x2_gold;

    [SerializeField]
    private HolidayInfo _holiday_info;



    public string Id
    {
        get
        {
            return _guid;
        }

        private set
        {
            _guid = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }

        private set
        {
            _name = value;
        }
    }

    public int HeroesCount
    {
        get
        {
            return _heroes_info.Length;
        }
    }

    public int BossesCount
    {
        get
        {
            return _bosses_info.Length;
        }
    }

    public int SpellsCount
    {
        get
        {
            return _spells_info.Length;     
        }
    }

    public MapInfo MapInfo
    {
        get
        {
            return _map_info;
        }

        private set
        {
            _map_info = value;
        }
    }

    public SystemLanguage Language
    {
        get
        {
            return _language;
        }

        private set
        {
            _language = value;
        }
    }

    public int Gold
    {
        get
        {
            return _gold;
        }

        private set
        {
            _gold = value;
        }
    }

    public int Diamonds
    {
        get
        {
            return _diamonds;
        }

        private set
        {
            _diamonds = value;
        }
    }

    public int Stars
    {
        get
        {
            return _stars;
        }

        private set
        {
            _stars = value;
        }
    }

    public int Wins
    {
        get
        {
            return _wins;
        }

        private set
        {
            _wins = value;
        }
    }

    public int PlayedGames
    {
        get
        {
            return _played_games;
        }

        private set
        {
            _played_games = value;
        }
    }

    public int TotalGold
    {
        get
        {
            return _total_gold;
        }

        private set
        {
            _total_gold = value;
        }
    }

    public int TotalDiamonds
    {
        get
        {
            return _total_diamonds;
        }

        private set
        {
            _total_diamonds = value;
        }
    }

    public int TotalStars
    {
        get
        {
            return _total_stars;
        }

        private set
        {
            _total_stars = value;
        }
    }

    public int AchievementsCount
    {
        get
        {
            return _achievementsInfo.Length;
        }
    }

    public int TowerLevel
    {
        get
        {
            return _towerLevel;
        }

        private set
        {
            _towerLevel = value;
        }
    }

    public int Keys
    {
        get
        {
            return _keys;
        }

        private set
        {
            _keys = value;
        }
    }

    public DeckInfo Deck
    {
        get
        {
            return _deckInfo;
        }

        private set
        {
            _deckInfo = value;
        }
    }

    public float SfxVolume
    {
        get
        {
            return _sfx_volume;
        }

        private set
        {
            _sfx_volume = value;
        }
    }

    public float MusicVolume
    {
        get
        {
            return _music_volume;
        }

        private set
        {
            _music_volume = value;
        }
    }

    public float SpentMoney
    {
        get
        {
            return _spent_money;
        }

        private set
        {
            _spent_money = value;
        }
    }

    public bool IsInfinityKeys
    {
        get
        {
            return _is_infinity_keys;
        }

        private set
        {
            _is_infinity_keys = value;
        }
    }

    public bool IsX2Gold
    {
        get
        {
            return _is_x2_gold;
        }

        private set
        {
            _is_x2_gold = value;
        }
    }

    public HolidayInfo HolidayInfo
    {
        get
        {
            return _holiday_info;
        }

        private set
        {
            _holiday_info = value;
        }
    }



    public HeroInfo GetHeroInfo(int index)
    {
        if (index < 0 || index >= HeroesCount)
            return null;

        return _heroes_info[index];
    }

    public BossInfo GetBossInfo(int index)
    {
        if (index < 0 || index >= BossesCount)
            return null;

        return _bosses_info[index];
    }

    public SpellInfo GetSpellInfo(int index)
    {
        if (index < 0 || index >= SpellsCount)
            return null;

        return _spells_info[index];
    }

    public AchievementInfo GetAchievementInfo(int index)
    {
        if (index < 0 || index >= AchievementsCount)
            return null;

        return _achievementsInfo[index];
    }
    


    public PlayerData()
    {
        _guid = Guid.NewGuid().ToString();
        _name = $"guest";

        _heroes_info = new HeroInfo[20];
        _bosses_info = new BossInfo[12];
        _spells_info = new SpellInfo[0];
        _map_info = new MapInfo();

        SfxVolume = 1f;

        MusicVolume = 1f;
    }
}
