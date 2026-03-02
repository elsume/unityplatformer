using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endText;
    
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        string endReason = PlayerPrefs.GetString("EndReason", "Game Over");
        endText.text = endReason;
        scoreText.text = "Final Score: " + finalScore;
    }
    
    public void Retry()
    {
        SceneManager.LoadScene("gameScene");
    }
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}