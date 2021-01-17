using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System;
using System.Runtime.CompilerServices;

public class MyEventTrigger : FX, IPointerEnterHandler, IPointerDownHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        SelectFX();
        this.gameObject.transform.localScale = new Vector3(1.1f,1.1f,1);
       
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ClickFX();
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }


}
