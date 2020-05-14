using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollTheDice : MonoBehaviour
{
    public TextMeshProUGUI diceText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int StartRoll()
    {
        Random.InitState(System.DateTime.Now.Millisecond); //I've no idea what this doing
        int randomNum = Random.Range(1, 7);
        diceText.text = randomNum.ToString();

        return randomNum; //return value utk kegunaan image array (imageCollection)
    }

}
