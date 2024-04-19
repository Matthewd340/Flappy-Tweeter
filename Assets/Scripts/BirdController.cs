using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    Rigidbody2D bird;
    int score = 0;
    public Text scoreText;
    public bool isAlive;
    public TextMeshProUGUI gameOverText;



    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        //Sets alive to true
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space) && isAlive)
        {
            bird.AddForce(new Vector2(0,1) * 200);
        }
        
        if(isAlive == false)
        {
            GameOver();
        }
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            //This increases the player score when they pass through the pipes
            score = score + 1;

            scoreText.text = score.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //alive is false
        isAlive = false;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
