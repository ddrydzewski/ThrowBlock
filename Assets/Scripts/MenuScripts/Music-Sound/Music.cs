using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioSource Audio1;
    public AudioSource Audio2;
    public AudioSource Audio3;

    public Player Player;

    private int MusicTrack;

    void Start()
    {
        MusicTrack = 1;
    }

    void Update()
    {
        if (Player.IsMusic == 0)
        {
            if (MusicTrack == 1 && Audio3.isPlaying == false)
            {
                Audio1.Play();
                MusicTrack = 2;
            }
            else if (MusicTrack == 2 && Audio1.isPlaying == false)
            {
                Audio2.Play();
                MusicTrack = 3;
            }
            else if (MusicTrack == 3 && Audio2.isPlaying == false)
            {
                Audio3.Play();
                MusicTrack = 1;
            }
        }
    }

    public void StopPlayingMusic()
    {
        Audio1.Stop();
        Audio2.Stop();
        Audio3.Stop();
    }
}
