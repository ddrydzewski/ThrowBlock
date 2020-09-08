using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour
{
    public Player Player;
    public UI Ui;
    public Block Block;
    public Effects Effects;
    public Sound Sound;
    public Music Music;

    public void StartGame()
    {     
        Player.StartGame = true;
        Ui.PlayerStartGame();
        Block.BlockRigidbody2D.gameObject.SetActive(true);
    }

    public void TurnSound()
    {
        if (Player.IsMusic == 0)
        {
            Player.IsMusic = 1;
            Music.StopPlayingMusic();
        }
        else if (Player.IsMusic == 1)
        {       
            Player.IsMusic = 0;
        }
    }

    public void BlockFall()
    {
        if (Player.CanPlayerTouch == true)
        {
            Player.TouchNow = true;
            Player.CanPlayerTouch = false;

            Block.BlockFall();
            Effects.BlockShine();

            if (Player.IsMusic == 0)
                Sound.TouchSound();
        }
    }

    public void RestartGame()
    {
        Block.RestartBlockNow = true;
    }
}
