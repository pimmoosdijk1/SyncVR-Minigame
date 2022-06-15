using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audiomanager : MonoBehaviour
{

    public static Audiomanager instance;


    void Awake()
    {

        if(instance ==null) // if you do not already have an audio listener
        {
            instance = this; // than this will be the audio listener
        }
        else
        {
            Destroy(gameObject); // or you already have an audio listener so destroy it
            return;
        }

       
        DontDestroyOnLoad(transform.gameObject);
    }

    


}
