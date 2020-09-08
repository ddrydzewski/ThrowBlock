using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public Block Block;
    private Color BlockColor;

    void Start()
    {
        BlockColor = Block.BlockSpriteRenderer.color;
    }

    public void BlockShine()
    {      
        StartCoroutine(WaitForShine());
    }

    IEnumerator WaitForShine()
    {
        Block.BlockSpriteRenderer.color = Color.green;
        yield return new WaitForSeconds(0.2f);
        Block.BlockSpriteRenderer.color = BlockColor;
    }
}
