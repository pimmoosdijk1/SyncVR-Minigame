using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score; //accessible from another script
    private int displayScore;
    public Text scoreUI;

    public static int hungryAnimals; //accessible from another script
    private int hungryAnimalsCount;
    public Text hungryUI;

    public Text animalsLeftUI;

    public Healthbar healthBar; // reference to another script

    


    void Start() //set scores to 0
    {
        score = 0;
        displayScore = 0;

        hungryAnimals = 0;
        hungryAnimalsCount = 0;
    }

    void Update()
    {
        if (score != displayScore) //display score and animals left
        {
            displayScore = score;
            scoreUI.text = ("Animals Fed: ")+ displayScore.ToString();
            animalsLeftUI.text =("Animals left to feed: ") + (100 - score);
        }

        if (hungryAnimals != hungryAnimalsCount) //display 'health' and animals missed
        {
            hungryAnimalsCount = hungryAnimals;
            hungryUI.text = ("Missed Animals: " + hungryAnimalsCount.ToString());
            healthBar.SetHealth(4- hungryAnimals); // reference to healthbar
        }

        //Gameover
        if (hungryAnimals >= 4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(score >= 100)
        {
            Debug.Log("You've Won");
            SceneManager.LoadScene("Won"); // load win screen /scene

        }
    }
}
