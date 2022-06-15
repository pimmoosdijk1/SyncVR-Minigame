using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    private int displayScore;
    public Text scoreUI;

    public static int hungryAnimals;
    private int hungryAnimalsCount;
    public Text hungryUI;

    public Text animalsLeftUI;

    public Healthbar healthBar; //test

    


    void Start()
    {
        score = 0;
        displayScore = 0;

        hungryAnimals = 0;
        hungryAnimalsCount = 0;


    }

    void Update()
    {
        if (score != displayScore)
        {
            displayScore = score;
            scoreUI.text = ("Animals Fed: ")+ displayScore.ToString();
            animalsLeftUI.text =("Animals left to feed: ") + (100 - score);
        }

        if (hungryAnimals != hungryAnimalsCount)
        {
            hungryAnimalsCount = hungryAnimals;
            hungryUI.text = ("Missed Animals: " + hungryAnimalsCount.ToString());
            healthBar.SetHealth(4- hungryAnimals); //test
        }

        //Gameover
        if (hungryAnimals >= 4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(score >= 5)
        {
            Debug.Log("You've Won");
            SceneManager.LoadScene("Won");

        }
    }
}
