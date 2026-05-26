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

    [Header("Task Checkmarks")]
    public GameObject passwordTaskCheckmark;

    [Header("Task Manager")]
    public TaskManager taskManager;

    // Husker om PC-en allerede er låst opp
    private bool pcUnlocked = false;

    // Hindrer at oppgaven telles flere ganger
    private bool passwordTaskCompleted = false;

    // -------------------------
    // FEIL PASSORD PÅ TABLET
    // -------------------------
    public void WrongAnswer()
    {
        feedbackText.text = "Dette passordet er for svakt.";
        feedbackText.color = Color.red;
    }

    // -------------------------
    // RIKTIG PASSORD PÅ TABLET
    // -------------------------
    public void CorrectAnswer()
    {
        feedbackText.text = "Bra jobbet! Husk passordet for å låse opp PC-en.";
        feedbackText.color = Color.green;

        // Fullfør oppgaven kun én gang
        if (!passwordTaskCompleted)
        {
            passwordTaskCompleted = true;

            if (passwordTaskCheckmark != null)
            {
                passwordTaskCheckmark.SetActive(true);
            }

            if (taskManager != null)
            {
                taskManager.CompleteTask();
            }
        }
    }

    // -------------------------
    // ÅPNE PC
    // -------------------------
    public void OpenPC()
    {
        if (pcUnlocked)
        {
            pcInboxPanel.SetActive(true);
        }
        else
        {
            pcLockedPanel.SetActive(true);

            passwordInput.text = "";
            pcFeedbackText.text = "";
        }
    }

    // -------------------------
    // SJEKK PASSORD
    // -------------------------
    public void CheckPassword()
    {
        if (passwordInput.text == correctPassword)
        {
            pcUnlocked = true;

            pcFeedbackText.text = "PC låst opp!";
            pcFeedbackText.color = Color.green;

            pcLockedPanel.SetActive(false);
            pcInboxPanel.SetActive(true);

            passwordInput.text = "";
        }
        else
        {
            pcFeedbackText.text = "Feil passord.";
            pcFeedbackText.color = Color.red;
        }
    }

    // -------------------------
    // LUKK PANEL
    // -------------------------
    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}