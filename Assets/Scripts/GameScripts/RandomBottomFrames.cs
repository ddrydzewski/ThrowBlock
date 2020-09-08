using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBottomFrames : MonoBehaviour
{
    public GameObject LeftFrame;
    public GameObject RightFrame;

    private float FirstRange, SecondRange, SumOfRanges;
    private const float SizeOfBottom = 2.62f;
    private const float RangeSize = 2.1f;

    void Start()
    {
        RestartFrames();
    }

    public void RestartFrames()
    {
        RandomFrames();
        LeftFrame.transform.localScale = new Vector3(FirstRange, LeftFrame.transform.localScale.y, LeftFrame.transform.localScale.z);
        RightFrame.transform.localScale = new Vector3(SecondRange, RightFrame.transform.localScale.y, RightFrame.transform.localScale.z);
    }

    void RandomFrames()
    {
        SumOfRanges = 0;
        while (SumOfRanges < RangeSize)
        {
            FirstRange = Random.Range(0, SizeOfBottom);
            SecondRange = Random.Range(0, SizeOfBottom - FirstRange);
            SumOfRanges = FirstRange + SecondRange;
        }
    }
}
