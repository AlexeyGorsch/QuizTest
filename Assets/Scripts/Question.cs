using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using System.Xml;
 using System.Xml.Serialization;

[System.Serializable]
public class Question
{
    public string questionRus;
    public string questionEng;
    public string questionChi;
    public List<Ask> ask;
    
}

[System.Serializable]

public class Ask
{
    public string answerRus;
    public string answerEng;
    public string answerChi;
    public bool right = false;
}

[System.Serializable]
public class Lang
{
    public string rusText;
    public string engText;
    public string chiText;
    public GameObject button;

}
