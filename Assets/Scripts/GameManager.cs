using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void EndGame() // en game and restart
    {
        if(gameHasEnded == false) // check if game hasnt yet ended
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay); //run reload method after delay
        }        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restart active scene (gamescene)
    }
}
