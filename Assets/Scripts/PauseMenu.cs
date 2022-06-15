using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false; //game starts unpaused

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // when escape is pressed activate pausemenu
        {
            if (GameIsPaused)
            {
                Resume(); //resume game
            }
            else
            {
                Pause(); //pause game
            }
        }
    }
    public void Resume() //resume game
    {
        PauseMenuUI.SetActive(false); //deactivate pausemenu screen
        Time.timeScale = 1f; //time is normal
        GameIsPaused = false; //change bool to not paused
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true); // activate pause menu screen
        Time.timeScale = 0f; // in game time is fully paused
        GameIsPaused = true; //change bool to paused
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //time is normal
        SceneManager.LoadScene("Menu"); //load menu screen
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit(); //quit game
    }
}
