using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct Holiday
{
    public DateTime start;
    
    public DateTime end;

    public EDecoration decoration;

    public bool give_gift;

    public EGoldCounter gold_counter;

}

public enum EDecoration
{
    none,
}

public enum EGoldCounter
{
    x1 = 1, x3 = 3, x5 = 5, x7 = 7, x10 = 10,
}
