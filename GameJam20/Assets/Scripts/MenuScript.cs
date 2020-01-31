﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void QuitGame() //This function closes the application when triggered
    {
        Application.Quit();
    }

    public void PlayGame() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void EndGameMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("EndGameMenu");
    }

    public void GameOverMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("GameOverMenu");
    }
}
