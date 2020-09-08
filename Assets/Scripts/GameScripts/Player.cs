using UnityEngine;

public class Player : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    
    public int Score { get; set; }
    public int HighScore { get; set; }
    public int CleanCombo { get; set; }
    public int HighCleanCombo { get; set; }
    public string Name { get; set; }
    public int IsMusic { get; set; }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    public bool StartGame { get; set; }
    public bool TouchNow { get; set; } 
    public bool CanPlayerTouch { get; set; }
    public bool ScorePoint { get; set; }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////

    public SaveAndLoad SaveScript;

    void Start()
    {
        Restart();
        StartGame = false;
        Name = "Player";
    }

    public void Restart()
    {
        TouchNow = false;
        CanPlayerTouch = true;
        ScorePoint = false;
        if (Score > HighScore)
        {
            HighScore = Score;
            SaveScript.Save();
        }
        CleanCombo = 1;
        Score = 0;
    }

    public void NextPoint()
    {
        TouchNow = false;
        CanPlayerTouch = true;
        ScorePoint = false;
        if (CleanCombo > HighCleanCombo)
        {
            HighCleanCombo = CleanCombo;
            SaveScript.Save();
        }
    }
}
