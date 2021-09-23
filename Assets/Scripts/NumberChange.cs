using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberChange : MonoBehaviour
{
    // Start is called before the first frame update

    public Text buttonText;
    public int number = 1;
    public int maxNumber = 10;

    void Start()
    {
        buttonText.GetComponent<Text>().text = number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked()
    {
        number++;
        if ( number > maxNumber)
        {
            number = 0;
        }
        buttonText.GetComponent<Text>().text = number.ToString();
    }
}
