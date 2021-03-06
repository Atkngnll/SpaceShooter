﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject menuButton;

    public void pauseGame()
    {
        if(GameIsPaused)
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        else
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
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
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Loading Menu!");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }

}
