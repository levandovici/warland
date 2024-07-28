using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class HolidayInfo
{
    [SerializeField]
    private EHoliday _holiday;

    [SerializeField]
    private DateTime _first_enter;

    [SerializeField]
    private bool _is_gift_geted;



    public EHoliday Holiday
    {
        get
        {
            return _holiday;
        }

        private set
        {
            _holiday = value;
        }
    }

    public DateTime FirstEnter
    {
        get
        {
            return _first_enter;
        }

        private set
        {
            _first_enter = value;
        }
    }

    public bool IsGiftGeted
    {
        get
        {
            return _is_gift_geted;
        }

        private set
        {
            _is_gift_geted = value;
        }
    }



    public HolidayInfo(EHoliday holiday, DateTime firstEnter, bool isGiftGeted)
    {
        Holiday = holiday;

        FirstEnter = firstEnter;

        IsGiftGeted = isGiftGeted;
    }
}

public enum EHoliday
{
    none,
}
