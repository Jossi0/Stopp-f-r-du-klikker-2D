using UnityEngine;

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


    public void OpenGiftMail()
    {
        CloseAllMailPanels();
        giftMailPanel.SetActive(true);
    }

    public void OpenKontoMail()
    {
        CloseAllMailPanels();
        kontoMailPanel.SetActive(true);
    }

    public void OpenSchoolMail()
    {
        CloseAllMailPanels();
        schoolMailPanel.SetActive(true);
    }

    public void OpenLibraryMail()
    {
        CloseAllMailPanels();
        libraryMailPanel.SetActive(true);
    }

    public void OpenIdrettMail()
    {
        CloseAllMailPanels();
        idrettMailPanel.SetActive(true);
    }
    
    public void OpenBusskortMail()
    {
        CloseAllMailPanels();
        busskortMailPanel.SetActive(true);
    }

    public void CloseMail(GameObject mailPanel)
    {
        mailPanel.SetActive(false);
    }

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