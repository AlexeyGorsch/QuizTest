using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AddEventTrigger : MyButton
{ 
    public void AddEventT(Button name)
    {
        name.gameObject.AddComponent<MyEventTrigger>();
        name.GetComponent<MyEventTrigger>().selectFX = selectFX.GetComponentInParent<AudioSource>();
        name.GetComponent<MyEventTrigger>().clickFX = clickFX.GetComponentInParent<AudioSource>();
    }
    public void AddEventTriggerOnButton()
    {
        foreach (var button in buttonList)
            AddEventT(button);
    }
}
