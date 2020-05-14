using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageCollection : MonoBehaviour
{
    public Sprite[] daduImage; //simpan all sprite
    public Image displayImage; //reference to script

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setImage()
    {
        int count = FindObjectOfType<Button>().GetComponent<RollTheDice>().StartRoll(); //collect return value utk kegunaan ni
        
        displayImage.sprite = daduImage[count-1];
    }
}
