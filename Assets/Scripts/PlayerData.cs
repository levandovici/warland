using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerData
{
    public string guid;

    public string name;

    public HeroInfo[] heroes_info;

    public BossInfo[] bosses_info;

    public SpellInfo[] spells_info;

    public SystemLanguage language;

    public int gold;

    public int diamonds;

    public int stars;

    public int wins;

    public int played_games;

    public int total_gold;

    public int total_diamonds;

    public int total_stars;

    public AchievementInfo[] achievementsInfo;

    public int towerLevel;

    public int keys;

    public DeckInfo deckInfo;

    public float sfx_volume;

    public float music_volume;

    public float spend_money;

    public bool is_infinity_keys;

    public bool is_x2_gold;

    public HolidayInfo holiday_info;

    public LogInToken token;
}
