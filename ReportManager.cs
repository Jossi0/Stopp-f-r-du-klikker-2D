using UnityEngine;

public class ReportManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject reportPanel;
    public GameObject successPanel;
    public GameObject failPanel;
    public GameObject inboxPanel;

    [Header("Task")]
    public GameObject reportTaskCheckmark;
    public TaskManager taskManager;

    // Husker hvilken mail som ble valgt
    private bool selectedMailIsScam;

    // Hindrer at oppgaven telles flere ganger
    private bool reportTaskCompleted = false;

    // -------------------------
    // ÅPNE REPORT PANEL
    // -------------------------

    public void OpenReportPanel(bool isScam)
    {
        selectedMailIsScam = isScam;

        reportPanel.SetActive(true);
    }

    // -------------------------
    // RAPPORTER MAIL
    // -------------------------

    public void ReportMail()
    {
        reportPanel.SetActive(false);

        // Hvis mailen faktisk er scam
        if (selectedMailIsScam)
        {
            successPanel.SetActive(true);

            // Fullfør oppgaven kun én gang
            if (!reportTaskCompleted)
            {
                reportTaskCompleted = true;

                if (reportTaskCheckmark != null)
                {
                    reportTaskCheckmark.SetActive(true);
                }

                if (taskManager != null)
                {
                    taskManager.CompleteTask();
                }
            }
        }
        else
        {
            failPanel.SetActive(true);
        }
    }

    // -------------------------
    // AVBRYT
    // -------------------------

    public void CancelReport()
    {
        reportPanel.SetActive(false);
    }

    // -------------------------
    // TILBAKE TIL INBOX
    // -------------------------

    public void ReturnToInbox()
    {
        successPanel.SetActive(false);
        failPanel.SetActive(false);

        inboxPanel.SetActive(true);
    }
}