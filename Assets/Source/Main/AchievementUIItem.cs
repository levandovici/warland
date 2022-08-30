using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUIItem : UIItem
{
    [SerializeField]
    private Text _position;

    [SerializeField]
    private Text _achievement;

    [SerializeField]
    private Text _progress;

    [SerializeField]
    private GameObject _star_first;

    [SerializeField]
    private GameObject _star_second;

    [SerializeField]
    private GameObject _star_third;



    public void SetUp(int position, string achievement, int progress, int max, bool firstStar, bool secondStar, bool thirdStar)
    {
        _position.text = $"{position}";

        _achievement.text = achievement;

        _progress.text = $"{progress}/{max}";

        SetUpStars(firstStar, secondStar, thirdStar);
    }

    public void SetUpStars(bool firstStar, bool secondStar, bool thirdStar)
    {
        _star_first.SetActive(firstStar);
        _star_second.SetActive(secondStar);
        _star_third.SetActive(thirdStar);
    }
}


