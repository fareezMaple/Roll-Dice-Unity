using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageCollection : MonoBehaviour
{
    public Sprite[] daduImage; //simpan all sprite
    private Image displayImage;
    public GameObject rollButton;

    
    // Start is called before the first frame update
    void Start()
    {
        displayImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setImage()
    {
        int count = rollButton.GetComponent<Button>().GetComponent<RollTheDice>().StartRoll();
        displayImage.sprite = daduImage[count - 1];
    }
}
