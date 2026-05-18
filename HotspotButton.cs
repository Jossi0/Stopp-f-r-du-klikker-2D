using UnityEngine;

public class HotspotButton : MonoBehaviour
{
    public GameObject panelToOpen;

    public void OpenPanel()
    {
        panelToOpen.SetActive(true);
    }

    public void ClosePanel()
    {
        panelToOpen.SetActive(false);
    }
}