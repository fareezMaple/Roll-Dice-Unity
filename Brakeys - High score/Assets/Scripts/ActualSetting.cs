using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualSetting : MonoBehaviour
{
    public GameObject RollButton1;
    public GameObject RollButton2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SoundOrMute(bool status)
    {
        RollButton1.GetComponent<AudioSource>().mute = RollButton2.GetComponent<AudioSource>().mute = !status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
