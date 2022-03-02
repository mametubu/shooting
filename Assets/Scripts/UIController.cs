using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    // Start is called before the first frame update
    public void GameOver()
    {
        this.gameOverText.GetCompoent<Text>().text = "GameOver";
    }
    public void AddScore()
    {
        this.score += 10;
    }
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
