using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageCollectionDouble : MonoBehaviour
{
    public Dice dice;
    public Sprite[] diceImage;

    private Image image1;
    private Image image2;

    private void Start()
    {
        image1 = gameObject.transform.GetChild(1).GetComponent<Image>();
        image2 = gameObject.transform.GetChild(0).GetComponent<Image>();
    }
    public void setImage()
    {
        image1.sprite = diceImage[dice.getNum1 - 1];
        image2.sprite = diceImage[dice.getNum2 - 1];
    }
}
