using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject timeOutPanel;
    public GameObject finalWinPanel;

    [Header("Tasks")]
    public int totalTasks = 4;

    private int completedTasks = 0;
    private bool gameEnded = false;

    public void CompleteTask()
    {
        if (gameEnded)
            return;

        completedTasks++;

        Debug.Log("Oppgave fullført: " + completedTasks + "/" + totalTasks);

        if (completedTasks >= totalTasks)
        {
            gameEnded = true;

            if (finalWinPanel != null)
                finalWinPanel.SetActive(true);
        }
    }

    public void TimeRanOut()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        if (timeOutPanel != null)
            timeOutPanel.SetActive(true);
    }
}