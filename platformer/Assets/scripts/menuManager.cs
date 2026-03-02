using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private int playerScore = 0;
    public void GameOver()
    {
        PlayerPrefs.SetInt("FinalScore", playerScore);
        PlayerPrefs.Save();
        
        SceneManager.LoadScene("GameOver");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("gameScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}