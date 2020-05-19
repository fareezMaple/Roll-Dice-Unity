using MaterialUI;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    public GameObject SettingPanel;
    public GameObject SettingBackground;
    public RectTransform rippleMask;

    public void showPanel()
    {
        SettingPanel.SetActive(true);

        if (!SettingBackground.activeSelf)
        {
            SettingBackground.SetActive(true);
            Debug.Log(SettingBackground.activeSelf);
        }
        SettingBackground.GetComponent<ScreenConfig>().Show(); //ripple show
    }
    
    public void hidePanel() //collapse
    {
        SettingPanel.SetActive(false);
        SettingBackground.GetComponent<ScreenConfig>().Hide(); //ripple control

        rippleMask.localScale = new Vector3(.1f, .1f, .1f); //ni punca   
    }

    public void viewOnGooglePlay()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.maple.DiceDadu");
    }
}
