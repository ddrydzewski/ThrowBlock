using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollision : MonoBehaviour
{
    public Block Block;
    public Player Player;

    void OnTriggerEnter2D(Collider2D otherCollider2D)
    {
        if (otherCollider2D.gameObject.name == "PointPanel")
        {
            StartCoroutine(WaitLittleForPoint());
        }
    }

    IEnumerator WaitLittleForPoint()
    {
        yield return new WaitForSeconds(0.5f);
        GetPoints();
        Player.ScorePoint = true;
    }

    void GetPoints()
    {
        if (Block.CleanFall == true)
        {
            if (Player.CleanCombo < 9)
                Player.CleanCombo++;

            Player.Score += Player.CleanCombo;
        }
        else
        {
            Player.CleanCombo = 1;
            Player.Score++;
        }
    }
}
