using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Body : AddEventTrigger
{
    void Start()
    {
        QuestionsInitDB();
        MyButtonAdd();
        AddEventTriggerOnButton();
        ToWindowStart();
    }

    void Update()
    {
        ButtonPush();

        // Debug.Log(Done);
        // Debug.Log("id :" + Id);
        // Debug.Log("countRight :" + CountRight);
        // Debug.Log("countWrong :" + CountWrong);
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     WrongAnswerFX();
        // }
    }
}
