using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollTheDice : MonoBehaviour
{
    public TextMeshProUGUI diceText;

    public int StartRoll()
    {
        Random.InitState(System.DateTime.Now.Millisecond); //I've no idea what this doing
        int randomNum = Random.Range(1, 7);
        diceText.text = randomNum.ToString();

        Debug.Log("Called Roll The Dice");

        return randomNum; //return value utk kegunaan image array (imageCollection)
    }

}
