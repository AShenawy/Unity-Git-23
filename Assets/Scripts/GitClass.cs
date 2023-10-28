using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatClass : MonoBehaviour
{
    string myName = "Slim Shady";
    int myPower = 8001;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is Git. May name is Gat. My name is wikawaka" + myName);

        if (myPower > 9000)
        {
            print("It's over 9000!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}