using UnityEngine;

public class ClosePanelButton : MonoBehaviour
{
    public RectTransform Panel;
    public void ClosePanel()
    {
        if(Panel == null)
        {
            Debug.LogError("No panel has been set");
            return;
        }
        Panel.gameObject.SetActive(false);
    }
}
