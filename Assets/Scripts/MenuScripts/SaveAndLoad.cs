using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    public Player Player;

    void Start()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerHighScore",Player.HighScore);
        PlayerPrefs.SetInt("PlayerLikeMusic",Player.IsMusic);
    }

    void Load()
    {
        Player.HighScore = PlayerPrefs.GetInt("PlayerHighScore", 0);
        Player.IsMusic = PlayerPrefs.GetInt("PlayerLikeMusic", 0);
    }
}
