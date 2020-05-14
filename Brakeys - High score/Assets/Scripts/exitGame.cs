using UnityEngine;

public class exitGame : MonoBehaviour
{
    public GameObject quitText;

    public void quitGame()
    {
        Application.Quit();
        quitText.SetActive(true); //display 'Quitting...' text

    }
}
