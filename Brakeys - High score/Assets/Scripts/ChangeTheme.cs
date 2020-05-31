using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTheme : MonoBehaviour
{
    private string DarkMode = "Dark";
    private string LightMode = "Light";
    
    public void changeTheme(string ThemeMode)
    {
        if (ThemeMode == LightMode)
            SceneManager.LoadScene(1); //load light scene

        if (ThemeMode == DarkMode)
            SceneManager.LoadScene(2); //load dark scene
    }
}
