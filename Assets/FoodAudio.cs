using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAudio : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip audioClip;

    public void EatSound()
    {
        //audioPlayer.PlayOneShot(audioClip, 1f);

        Debug.Log("EatSound");

    }
}
