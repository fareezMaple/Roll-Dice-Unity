using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThemeLoaderManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int themeIndex = PlayerPrefs.GetInt("ThemeMode", 1);
        SceneManager.LoadScene(themeIndex);
    }
}
