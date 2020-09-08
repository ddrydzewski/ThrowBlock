using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Sound1;
    public AudioSource Sound2;

    public void TouchSound()
    {
        Sound1.Play();
    }

    public void EndOfGameSound()
    {
        Sound2.Play();
    }
}
