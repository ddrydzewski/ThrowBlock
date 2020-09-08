using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Block Block;
    public Player Player;
    public UI Ui;
    public RandomBottomFrames RandomBottomFrames;
    public Sound Sound;

    void Start()
    {
        StartCoroutine(MainLoop());
    }

    IEnumerator MainLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            ResetEachPoint();
            RestartEachGame();
            yield return null;
        }
    }

    void ResetEachPoint()
    {
        if (Player.ScorePoint == true)
        {
            Block.BlockNextPoint();
            Player.NextPoint();
            RandomBottomFrames.RestartFrames();
        }
    }

    void RestartEachGame()
    {
        if (Block.RestartBlockNow == true)
        {
            Block.RestartBlock();
            Player.Restart();
            Ui.UIRestartGame();
            RandomBottomFrames.RestartFrames();
        }
    }
}
