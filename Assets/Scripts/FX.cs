using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FX : MonoBehaviour
{
    [SerializeField]
   public  AudioSource wrongAnswerFX, rightAnswerFX, selectFX, clickFX;

   public  void WrongAnswerFX()
   {
        wrongAnswerFX.Play();
   }
    public  void RightAnswerFX()
    {
        rightAnswerFX.Play();
    }
    public  void SelectFX()
    {
    
        selectFX.Play();
    }
    public  void ClickFX()
    {
       
        clickFX.Play();
    }

    
   

}