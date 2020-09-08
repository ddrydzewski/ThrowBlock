using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text ScoreText;
    public Text StartText;
    public Text RetryText;
    public Text HighScoreText;
    public Text CleanText;
    public Text SoundChangeText;

    public GameObject StartPanel;
    public GameObject TapPanel;
    public GameObject PointPanel;
    public GameObject RetryPanel;
    public GameObject SoundPanel;

    public Image ThemeImage;

    public Block Block;
    public Player Player;

    void Start()
    {
        OnStartUIGame();
        StartCoroutine(WaitForText());
    }

    IEnumerator WaitForText()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (Player.ScorePoint == true && Block.CleanFall == true)
                CleanTextAni();

            if (Player.StartGame == true)
                ScoreText.text = Player.Score.ToString();

            if (Block.BlockStuckEnd == true)
            {
                RetryText.gameObject.SetActive(true);
                RetryPanel.gameObject.SetActive(true);
                HighScoreText.gameObject.SetActive(true);
                HighScoreText.text = "HighScore: " + Player.HighScore.ToString();
                TurnSoundText();
            }

            yield return null;
        }
    }

    IEnumerator WaitForClean()
    {
        CleanText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        CleanText.gameObject.SetActive(false);
    }

    public void UIRestartGame()
    {
        RetryText.gameObject.SetActive(false);
        RetryPanel.gameObject.SetActive(false);
        HighScoreText.gameObject.SetActive(false);
        CleanText.gameObject.SetActive(false);
        SoundChangeText.gameObject.SetActive(false);
        SoundPanel.gameObject.SetActive(false);
    }

    public void PlayerStartGame()
    {
        StartPanel.gameObject.SetActive(false);
        StartText.gameObject.SetActive(false);
        ScoreText.gameObject.SetActive(true);
        TapPanel.gameObject.SetActive(true);
        ThemeImage.gameObject.SetActive(false);
    }

    void OnStartUIGame()
    {
        ScoreText.gameObject.SetActive(false);
        RetryText.gameObject.SetActive(false);
        HighScoreText.gameObject.SetActive(false);
        CleanText.gameObject.SetActive(false);
        SoundChangeText.gameObject.SetActive(false);

        TapPanel.gameObject.SetActive(false);
        RetryPanel.gameObject.SetActive(false);
        SoundPanel.gameObject.SetActive(false);
    }


    void CleanTextAni()
    {
        CleanText.text = "CLEAN COMBO " + "x" + (Player.CleanCombo).ToString();
        StartCoroutine(WaitForClean());
    }

    void TurnSoundText()
    {
        SoundChangeText.gameObject.SetActive(true);
        SoundPanel.gameObject.SetActive(true);
        if (Player.IsMusic == 0)
        {
            SoundChangeText.text = "Sound ON";
        }
        else
        {
            SoundChangeText.text = "Sound OFF";
        }
    }
}
