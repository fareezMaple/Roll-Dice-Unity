using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardInput : MonoBehaviour
{
    public GameObject singleMode; //check if mode is on/off
    public GameObject doubleMode;
    public GameObject tooltipText;
    
    public Button rollSingle;
    public Button rollDouble;
    public Button settingBtn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (singleMode.activeSelf)
            {
                rollSingle.onClick.Invoke();
                
            } else if (doubleMode.activeSelf)
            {
                rollDouble.onClick.Invoke();
            }
        } //roll button
        
        if (Input.GetKeyDown(KeyCode.S))
            settingBtn.onClick.Invoke();

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            tooltipText.SetActive(!tooltipText.activeSelf);
        }
    }
}
