using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    [SerializeField]
    private bool _passed;

    [SerializeField]
    private EMaxStars _maxStars;



    public bool IsPassed
    {
        get
        {
            return _passed;
        }

        private set
        {
            _passed = value;
        }
    }

    public EMaxStars MaxStars
    {
        get
        {
            return _maxStars;
        }

        private set
        {
            _maxStars = value;
        }
    }



    public Level()
    {
        IsPassed = false;

        MaxStars = EMaxStars.Zero;
    }

    public enum EMaxStars
    {
        Zero = 0, One = 1, Two = 2, Three = 3,
    }
}
