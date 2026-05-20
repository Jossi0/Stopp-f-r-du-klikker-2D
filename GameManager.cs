using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject gameOverPanel;
    public GameObject winPanel;

    [Header("UI")]
    public TMP_Text progressText;

    [Header("Progress")]
    public int correctAnswers = 0;
    public int totalMails = 5;

    // Spilleren valgte riktig
    public void CorrectChoice()
    {
        correctAnswers++;

        progressText.text = correctAnswers + " / " + totalMails;

        if (correctAnswers >= totalMails)
        {
            winPanel.SetActive(true);
        }
    }

    // Spilleren gjorde feil
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
}