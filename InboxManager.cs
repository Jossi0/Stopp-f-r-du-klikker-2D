using UnityEngine;
using UnityEngine.SceneManagement;

public class InboxManager : MonoBehaviour
{
    [Header("Main Panels")]
    public GameObject inboxPanel;

    [Header("Mail Panels")]
    public GameObject giftMailPanel;
    public GameObject kontoMailPanel;
    public GameObject schoolMailPanel;
    public GameObject libraryMailPanel;
    public GameObject idrettMailPanel;
    public GameObject busskortMailPanel;

    [Header("Result Panels")]
    public GameObject winPanel;
    public GameObject gameOverPanel;

    // -------------------------
    // OPEN MAILS
    // -------------------------

    public void OpenGiftMail()
    {
        OpenMail(giftMailPanel);
    }

    public void OpenKontoMail()
    {
        OpenMail(kontoMailPanel);
    }

    public void OpenSchoolMail()
    {
        OpenMail(schoolMailPanel);
    }

    public void OpenLibraryMail()
    {
        OpenMail(libraryMailPanel);
    }

    public void OpenIdrettMail()
    {
        OpenMail(idrettMailPanel);
    }

    public void OpenBusskortMail()
    {
        OpenMail(busskortMailPanel);
    }

    void OpenMail(GameObject mailPanel)
    {
        CloseAllMailPanels();

        inboxPanel.SetActive(false);
        mailPanel.SetActive(true);
    }

    // -------------------------
    // CLOSE MAIL
    // -------------------------

    public void CloseMail(GameObject mailPanel)
    {
        mailPanel.SetActive(false);
        inboxPanel.SetActive(true);
    }

    // -------------------------
    // ANSWERS
    // -------------------------

    public void CorrectChoice(GameObject currentMail)
    {
        currentMail.SetActive(false);

        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }
    }

    public void WrongChoice(GameObject currentMail)
    {
        currentMail.SetActive(false);

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    // -------------------------
    // RETURN TO INBOX
    // -------------------------

    public void ReturnToInbox()
    {
        CloseAllMailPanels();

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }

        inboxPanel.SetActive(true);
    }

    // -------------------------
    // RESTART GAME
    // -------------------------

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // -------------------------
    // HELPERS
    // -------------------------

    void CloseAllMailPanels()
    {
        giftMailPanel.SetActive(false);
        kontoMailPanel.SetActive(false);
        schoolMailPanel.SetActive(false);
        libraryMailPanel.SetActive(false);
        idrettMailPanel.SetActive(false);
        busskortMailPanel.SetActive(false);
    }
}