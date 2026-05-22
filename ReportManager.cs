using UnityEngine;

public class ReportManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject reportPanel;
    public GameObject successPanel;
    public GameObject failPanel;
    public GameObject inboxPanel;

    // Husker hvilken mail som ble valgt
    private bool selectedMailIsScam;

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