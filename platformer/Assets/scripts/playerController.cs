using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    
    private int health = 100;
    private int score = 0;

    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    
    private Rigidbody2D rb;
    private bool isGrounded = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateUI();
    }
    
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("enemy"))
        {
            TakeDamage(10);
        }
    }
    
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            score += 10;
            Destroy(other.gameObject);
            UpdateUI();

            if (score >= 80)
            {
                PlayerPrefs.SetString("EndReason", "You Collected All Coins!");
                GameOver();
            }
        }
    }
    
    void TakeDamage(int damage)
    {
        health -= damage;
        UpdateUI();
        
        if (health <= 0)
        {
            PlayerPrefs.SetString("EndReason", "You Died!");
            GameOver();
        }
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + health;
        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        PlayerPrefs.SetInt("FinalScore", score);
        SceneManager.LoadScene("GameOver");
    }
}