using UnityEngine;
using UnityEngine.UI;


public class leaderboardController : MonoBehaviour
{
    public Text score1, score2, score3, bestScore;
    int best, sc1, sc2, sc3;
    void Start()
    {
        sc1 = PlayerPrefs.GetInt("sc1");
        sc2 = PlayerPrefs.GetInt("sc2");
        sc3 = PlayerPrefs.GetInt("sc3");
        best = PlayerPrefs.GetInt("best");

        score1.text = "1� " + sc1;
        score2.text = "2� " + sc2;
        score3.text = "3� " + sc3;
        bestScore.text = "" + best;
    }

}
