using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button1;
    public GameObject button2;
    public int button1Number = 3;
    public int button2Number = 4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        if ( button1.GetComponent<NumberChange>().number == button1Number && button2.GetComponent<NumberChange>().number == button2Number)
        {
            Destroy(button1);
            Destroy(button2);
        }
    }
}
