using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "DUNJA";
    int myPower = 9001;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        if (myPower > 9000)
        {
            print("coolcoolcool");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}