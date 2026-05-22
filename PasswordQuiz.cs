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

    // Husker om PC-en allerede er låst opp
    private bool pcUnlocked = false;


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

        // Vis checkmark på oppgavepanelet
        if (passwordTaskCheckmark != null)
        {
            passwordTaskCheckmark.SetActive(true);
        }
    }


    // -------------------------
    // ÅPNE PC
    // -------------------------
    public void OpenPC()
    {
        // Hvis PC allerede er unlocked
        if (pcUnlocked)
        {
            pcInboxPanel.SetActive(true);
        }
        else
        {
            pcLockedPanel.SetActive(true);

            // Reset loginfelt
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
            // Lås opp PC permanent
            pcUnlocked = true;

            pcFeedbackText.text = "PC låst opp!";
            pcFeedbackText.color = Color.green;

            // Åpne inbox
            pcLockedPanel.SetActive(false);
            pcInboxPanel.SetActive(true);

            // Tøm inputfelt
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