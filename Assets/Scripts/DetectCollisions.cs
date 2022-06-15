using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class DetectCollisions : MonoBehaviour
{
    


    public int animalsFed = 0;
   
    public void OnTriggerEnter(Collider other)
    {
        //Deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Destroy(gameObject);
        Score.score++;

        //foodAudio.EatSound();

    }


}
