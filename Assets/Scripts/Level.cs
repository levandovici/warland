using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public bool passed;
    public EMaxStars maxStars;



    public Level()
    {
        passed = false;
        maxStars = 0;
    }

    public enum EMaxStars
    {
        zero = 0, one = 1, two = 2, three = 3,
    }
}
