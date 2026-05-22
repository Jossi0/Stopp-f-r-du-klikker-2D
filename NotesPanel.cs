using UnityEngine;

public class NotesPanel : MonoBehaviour
{
    [Header("Panels")]
    public GameObject notesPanel;

    [Header("Task Checkmark")]
    public GameObject notesTaskCheckmark;

    // Åpne notatpanel
    public void OpenNotes()
    {
        notesPanel.SetActive(true);

        // Vis checkmark
        if (notesTaskCheckmark != null)
        {
            notesTaskCheckmark.SetActive(true);
        }
    }

    // Lukk notatpanel
    public void CloseNotes()
    {
        notesPanel.SetActive(false);
    }
}