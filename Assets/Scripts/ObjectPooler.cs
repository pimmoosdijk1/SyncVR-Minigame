using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance; //make accesible from other scripts
    public List<GameObject> pooledObjects;
    public GameObject objectToPool; 
    public int amountToPool;

    void Awake()
    {
        SharedInstance = this; //
    }

    // Start is called before the first frame update
    void Start()
    {
        // Loop through list of pooled objects,deactivating them and adding them to the list 
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool); // instantiate object and store in gameobject
            obj.SetActive(false); // disable it
            pooledObjects.Add(obj); //add to ist of pooled objects
            obj.transform.SetParent(this.transform); // set as children of Spawn Manager
        }
    }

    public GameObject GetPooledObject()
    {
        // For as many objects as are in the pooledObjects list
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            // if the pooled objects is NOT active, return that object 
            if (!pooledObjects[i].activeInHierarchy)// is there an availible bullet you can shoot
            {
                return pooledObjects[i]; //return the bullet you can shoot
            }
        }
        // otherwise, return null   
        return null;
    }

}
