using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int playerScore = 0;
    
    public void GameOver()
    {
        PlayerPrefs.SetInt("FinalScore", playerScore);
        PlayerPrefs.Save();
        
        SceneManager.LoadScene("gameOver");
    }

    public void MainMenu()
    {
        Debug.Log("MainMenu button clicked!");
        SceneManager.LoadScene("mainMenu");
    }
}