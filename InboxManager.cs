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

    [Header("Mail Checkmarks")]
    public GameObject giftCheckmark;
    public GameObject kontoCheckmark;
    public GameObject schoolCheckmark;
    public GameObject libraryCheckmark;
    public GameObject idrettCheckmark;
    public GameObject busskortCheckmark;

    [Header("Task Checkmarks")]
    public GameObject allEmailsTaskCheckmark;

    [Header("Progress")]
    private int completedEmails = 0;
    private int totalEmails = 6;

    // Hindrer samme mail fra å telle flere ganger
    private bool giftDone = false;
    private bool kontoDone = false;
    private bool schoolDone = false;
    private bool libraryDone = false;
    private bool idrettDone = false;
    private bool busskortDone = false;

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
    // CORRECT ANSWER
    // -------------------------

    public void CorrectChoice(GameObject currentMail)
    {
        currentMail.SetActive(false);

        // GAVEKORT
        if (currentMail == giftMailPanel)
        {
            giftCheckmark.SetActive(true);

            if (!giftDone)
            {
                giftDone = true;
                completedEmails++;
            }
        }

        // KONTO
        else if (currentMail == kontoMailPanel)
        {
            kontoCheckmark.SetActive(true);

            if (!kontoDone)
            {
                kontoDone = true;
                completedEmails++;
            }
        }

        // SCHOOL
        else if (currentMail == schoolMailPanel)
        {
            schoolCheckmark.SetActive(true);

            if (!schoolDone)
            {
                schoolDone = true;
                completedEmails++;
            }
        }

        // LIBRARY
        else if (currentMail == libraryMailPanel)
        {
            libraryCheckmark.SetActive(true);

            if (!libraryDone)
            {
                libraryDone = true;
                completedEmails++;
            }
        }

        // IDRETT
        else if (currentMail == idrettMailPanel)
        {
            idrettCheckmark.SetActive(true);

            if (!idrettDone)
            {
                idrettDone = true;
                completedEmails++;
            }
        }

        // BUSSKORT
        else if (currentMail == busskortMailPanel)
        {
            busskortCheckmark.SetActive(true);

            if (!busskortDone)
            {
                busskortDone = true;
                completedEmails++;
            }
        }

        // VIS OPPGAVE-CHECKMARK NÅR ALLE MAILER ER FERDIGE
        if (completedEmails >= totalEmails)
        {
            if (allEmailsTaskCheckmark != null)
            {
                allEmailsTaskCheckmark.SetActive(true);
            }
        }

        // ÅPNE WIN PANEL
        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }
    }

    // -------------------------
    // WRONG ANSWER
    // -------------------------

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