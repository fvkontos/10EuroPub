using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI currentAmountText;
    public TextMeshProUGUI roundText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timerText;

    [SerializeField]
    Button restartButton;

    public bool isGameActive;

    public GameObject titleScreen;

    private double currentAmount = 0;
    public int currentRound = 0;

    private float timeLeft = 30f;

    private CoinCounter coinCounter;
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = GameObject.Find("Coin Counter").GetComponent<CoinCounter>();
    }

    // Update is called once per frame
    public void UpdateTime()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time : " + Mathf.Round(timeLeft);
        if(timeLeft < 0)
        {
            GameOver();
        }
    }

    private void Update()
    {
        if(isGameActive && coinCounter.total == 1000)
        {
            UpdateTime();
        }
        NextRound();
    }

    void NextRound()
    {
        if(currentAmount == 10)
        {
            coinCounter.total = 0;
            coinCounter.CoinGenerator();
            CurrentAmountPerRound(-10);
            UpdateRounds();
            if (currentAmount == 0)
            {
                timeLeft = 30f - currentRound;
            }
        }
    }

    public void CurrentAmountPerRound(double amount)
    {
        currentAmount += amount;
        currentAmountText.text = "Amount : " + currentAmount;
    }

    public void UpdateRounds()
    {
        currentRound++;
        roundText.text = "Round : " + currentRound;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void StartGame()
    {
        isGameActive = true;
        UpdateRounds();
        titleScreen.gameObject.SetActive(false);
    }
}
