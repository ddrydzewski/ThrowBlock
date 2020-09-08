using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    public Block Block;
    public Player Player;

    void OnCollisionEnter2D(Collision2D otherCollider2D)
    {
        // Block touch left or right frame then change side
        if (Player.TouchNow == false)
        {
            if (otherCollider2D.gameObject.name == "SideLeftFrame" && Block.ChangeTurn == false)
            {
                Block.ChangeTurn = true;
                Block.BlockRigidbody2D.velocity = Vector2.zero;
            }

            if (otherCollider2D.gameObject.name == "SideRightFrame" && Block.ChangeTurn == true)
            {
                Block.ChangeTurn = false;
                Block.BlockRigidbody2D.velocity = Vector2.zero;
            }
        }

        if (Player.TouchNow == true)
        {
            if (otherCollider2D.gameObject.name == "BottomFrameLeft")
            {
                Block.CleanFall = false;
            }

            if (otherCollider2D.gameObject.name == "BottomFrameRight")
            {
                Block.CleanFall = false;
            }
        }
    }
}
