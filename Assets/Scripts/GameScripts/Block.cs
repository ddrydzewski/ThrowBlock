using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public Rigidbody2D BlockRigidbody2D;
    public SpriteRenderer BlockSpriteRenderer;
    public Player Player;
    public Sound Sound;

    public bool ChangeTurn { get; set; }
    public bool BlockStuckEnd { get; set; }
    public bool RestartBlockNow { get; set; }
    public bool CleanFall { get; set; }

    private const float BlockSpeedX = 5.5f;

    void Start()
    {
        RestartBlock();
        BlockRigidbody2D.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Player.TouchNow == false)
        {
            if (ChangeTurn == false)
            {
                BlockRigidbody2D.velocity = new Vector2(-BlockSpeedX, 0);
            }
            else
            {
                BlockRigidbody2D.velocity = new Vector2(BlockSpeedX, 0);
            }
        }

        if (BlockRigidbody2D.velocity.x == 0 && BlockRigidbody2D.velocity.y == 0 && Player.TouchNow == true && BlockStuckEnd == false)
        {
            BlockStuckEnd = true;
            if (Player.IsMusic == 0)
                Sound.EndOfGameSound();
        }
    }

    public void RestartBlock()
    {
        ResetCommonThings();

        BlockStuckEnd = false;
        RestartBlockNow = false;
    }

    public void BlockNextPoint()
    {
        ResetCommonThings();
    }

    public void BlockFall()
    {
        BlockRigidbody2D.GetComponent<Rigidbody2D>().mass = 1;
        BlockRigidbody2D.GetComponent<Rigidbody2D>().gravityScale = 1;
        BlockRigidbody2D.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        BlockRigidbody2D.GetComponent<Rigidbody2D>().velocity -= new Vector2(0, 7);
    }

    void ResetCommonThings()
    {
        BlockRigidbody2D.mass = 0;
        BlockRigidbody2D.gravityScale = 0;
        BlockRigidbody2D.velocity = new Vector2(0.01f, 0.01f);
        BlockRigidbody2D.position = new Vector3(0, 3.68f, 0);
        BlockRigidbody2D.rotation = 0;
        BlockRigidbody2D.angularVelocity = 0;
        BlockRigidbody2D.rotation = 0;
        CleanFall = true;
        ChangeTurn = false;
    }
}
