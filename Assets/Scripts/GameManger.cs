using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{

    public static GameManger instance;

    public GameObject LifeHolder;
    public GameObject GameOverPanel;
    public GameObject VictoryPanel;

    int Score = 0;
    int Lives = 3;
    bool gameOver = false;

    public TMPro.TextMeshProUGUI scoreText;


    private void Awake() {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            Score++;
            scoreText.text = Score.ToString();
        }
        if (Score == 5)
        {
            Victory();
        }
    }

    public void DecreaseLives()
    {
        if (Lives > 0)
        {
            Lives--;
            //print (Lives);

            LifeHolder.transform.GetChild(Lives).gameObject.SetActive(false);
        }

        if (Lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

     public void GameOver()
    {
        
        CandySpawner.instance.StopSpawningCandies();
        GameOverPanel.SetActive(true);
        //print ("GameOver()");
    }

    public void Victory()
    {
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        VictoryPanel.SetActive(true);
        //print("Victory");
    }

    public void Restart()
    {

        SceneManager.LoadScene("Game");

    }
     public void Menu()
    {

        SceneManager.LoadScene("Menu");

    }
    

}
