using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instance;
    public Text ScoreText;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }


    public void UpdateScoreText()
    {
        ScoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    
}
