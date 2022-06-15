using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 30.0f;
    private float xRange = 20;
    public GameObject projectilePrefab;   

    
    void Update()
    {
        // Check if player moves inside of bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get an object object from the pool
            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject(); // get bullet from pool and store in gameobject
            if (pooledProjectile != null) //is there an availible bullet
            {
                pooledProjectile.SetActive(true); // activate projectile from pool
                pooledProjectile.transform.position = transform.position; // position projectile at player
            }
        }
    }
}
