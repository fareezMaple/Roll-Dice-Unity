using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualSetting : MonoBehaviour
{
    public GameObject RollButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SoundOrMute(bool status)
    {
        RollButton.GetComponent<AudioSource>().mute = !status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
