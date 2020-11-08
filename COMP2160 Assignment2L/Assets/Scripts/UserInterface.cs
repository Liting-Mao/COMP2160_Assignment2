using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour
{
    public Text timerTextMin;
    public Text timerTextSec;
    public Text timerTextMil;
    public Text gameOverText;
    public GameObject gameOverPanel;

    private string winText = "You win!";
    private string loseText = "You died!";
    
    private float gameTime;
    private float minutes;
    private float seconds;
    private float fraction;
    private float startTime;
     //Start is called before the first frame update
    void Start()
    {
    
        startTime = Time.time;
    
    }

     //Update is called once per frame
    void Update()
    {
        gameTime = Time.time - startTime;
        minutes = (gameTime) / 60;
        seconds = gameTime % 60;
        fraction = (gameTime * 100) % 100;
        timerTextMin.text = "" + minutes;
        timerTextSec.text = "" + seconds;
        timerTextMil.text = "" + fraction;
    
    }
    public void GameOver(bool win)
    {
        if (win)
        {
            gameOverText.text = winText;
        }
        else
        {
            gameOverText.text = loseText;
        }
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        // reload this scene
        SceneManager.LoadScene(0);
        gameOverPanel.SetActive(false);
    }
}

