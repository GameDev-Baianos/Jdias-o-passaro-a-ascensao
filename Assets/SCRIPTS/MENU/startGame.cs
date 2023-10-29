using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour 
{
    public GameObject startGameButton;
    public GameObject endGameButton;
    public TextMeshProUGUI timerObject;

    public void Update()
    {
        if (timerObject.text == "0")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void startGamefunction()
    {
        startGameButton.SetActive(false);
        startTimer();
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void startTimer()
    {
        timerObject.gameObject.SetActive(true);
        Invoke("decreaseTimer", 1);
    }

    public void decreaseTimer()
    {
        int newTimerValue = Convert.ToInt32(timerObject.text) - 1;
        timerObject.text = newTimerValue.ToString();
        Invoke("decreaseTimer", 1);
    }

}