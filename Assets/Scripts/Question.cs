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
    public List<Ask> ask;
    
}

[System.Serializable]

public class Ask
{
    public string answerRus;
    public string answerEng;
    public bool right = false;
}

[System.Serializable]
public class Lang
{
    public string RusText;
    public string EngText;
    public GameObject button;

}
