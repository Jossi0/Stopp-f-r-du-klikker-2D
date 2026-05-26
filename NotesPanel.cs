using UnityEngine;

public class NotesPanel : MonoBehaviour
{
    [Header("Panels")]
    public GameObject notesPanel;

    [Header("Task Checkmark")]
    public GameObject notesTaskCheckmark;

    [Header("Task Manager")]
    public TaskManager taskManager;

    private bool notesTaskCompleted = false;

    // Åpne notatpanel
    public void OpenNotes()
    {
        notesPanel.SetActive(true);

        // Fullfør oppgaven kun én gang
        if (!notesTaskCompleted)
        {
            notesTaskCompleted = true;

            if (notesTaskCheckmark != null)
            {
                notesTaskCheckmark.SetActive(true);
            }

            if (taskManager != null)
            {
                taskManager.CompleteTask();
            }
        }
    }

    // Lukk notatpanel
    public void CloseNotes()
    {
        notesPanel.SetActive(false);
    }
}