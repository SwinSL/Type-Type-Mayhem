﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UE = UnityEngine.SceneManagement;

public class PauseButtonHandler : MonoBehaviour
{
    /*
    * Build Index Reference (For LoadScene Function)
    * Main Menu - 0
    * Tutorial - 1
    * Story - 2
    * DifficultySelector - 3
    * EasyMode - 4
    */

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ToMainMenu()
    {
        Debug.Log("Main Menu is pressed");
        Time.timeScale = 1f;
        UE.SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit is pressed");
        Application.Quit();
    }
}

