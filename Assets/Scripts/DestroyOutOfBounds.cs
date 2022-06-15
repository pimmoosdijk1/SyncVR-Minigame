using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30; // border for projectile deactivation
    private float lowerBound = 2; //border for animal destroying

    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Deactivate object when it leaves the screen, for projectiles
            gameObject.SetActive(false); // dont destroy because its pooled

        }
        else if (transform.position.z < lowerBound) // if animals leaves screen:
        {
            Score.hungryAnimals++; //tell score script to add to hungry animals, decrease 'health'

            Destroy(gameObject); //destroy gameobject            
        }       

    }
}
