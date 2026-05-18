using UnityEngine;
using TMPro;

public class PasswordQuiz : MonoBehaviour
{
    [Header("Panels")]
    public GameObject tabletPanel;
    public GameObject pcLockedPanel;
    public GameObject pcInboxPanel;

    [Header("Tablet Feedback")]
    public TMP_Text feedbackText;

    [Header("PC Login")]
    public TMP_InputField passwordInput;
    public TMP_Text pcFeedbackText;

    [Header("Correct Password")]
    public string correctPassword = "Fisk!Måne-72Bok";


    public void WrongAnswer()
    {
        feedbackText.text = "Dette passordet er for svakt.";
        feedbackText.color = Color.red;
    }

    public void CorrectAnswer()
    {
        feedbackText.text = "Bra jobbet! Husk passordet for å låse opp PC-en.";
        feedbackText.color = Color.green;
    }


    public void OpenPC()
    {
        pcLockedPanel.SetActive(true);

        passwordInput.text = "";
        pcFeedbackText.text = "";
    }


    public void CheckPassword()
    {
        if (passwordInput.text == correctPassword)
        {
            pcFeedbackText.text = "PC låst opp!";
            pcFeedbackText.color = Color.green;

            pcLockedPanel.SetActive(false);
            pcInboxPanel.SetActive(true);
        }
        else
        {
            pcFeedbackText.text = "Feil passord.";
            pcFeedbackText.color = Color.red;
        }
    }


    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}