using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Yiqi Huang";
    int myPower = 7777;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        if (myPower > 7777)
        {
            print("It's over 9000!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}