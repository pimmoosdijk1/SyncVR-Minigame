using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); //load gamescene when pressed
    }

    public void QuitGame()
    {
        Debug.Log("You Quit!");
        Application.Quit(); //quit game when pressed
    }
}
