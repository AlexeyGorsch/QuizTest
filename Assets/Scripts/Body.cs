using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Body : Interface
{
 
    void Start()
    {
        Run();
        QuestionsInitDB();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonPush();
        Debug.Log(Done);
        Debug.Log("id :" + Id);
        Debug.Log("countRight :" + CountRight);
        Debug.Log("countWrong :" + CountWrong);
    }
}
