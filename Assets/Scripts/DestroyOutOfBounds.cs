using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = 2;

    private int hungryAnimals = 0;

    //public int maxHealth = 4;
    //public int currentHealth;

    //public Healthbar healthBar;

    //private void Start()
    //{
    //    currentHealth = maxHealth;
    //    healthBar.SetMaxHealth(maxHealth);
    //}


    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Deactivate object when it leaves the scree, for projectiles
            gameObject.SetActive(false); // dont destroy because its pooled

        }
        else if (transform.position.z < lowerBound)
        {
            Score.hungryAnimals++;
            //healthBar.SetHealth(currentHealth);


            //Debug.Log("Hungry animals" + hungryAnimals);
            Destroy(gameObject);
            
        }

        

    }
}
