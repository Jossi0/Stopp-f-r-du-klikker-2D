using UnityEngine;

public class MailPanel : MonoBehaviour
{
    public GameObject panelToClose;
    public GameManager gameManager;

    public void CorrectAnswer()
    {
        gameManager.CorrectChoice();

        panelToClose.SetActive(false);
    }

    public void WrongAnswer()
    {
        gameManager.GameOver();
    }
}