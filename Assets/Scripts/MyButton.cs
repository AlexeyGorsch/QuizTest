using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyButton : Interface
{
    public List<Button> buttonList = new List<Button>();
    public void MyButtonAdd()
    {
        buttonList.Add(buttonStartOnStartWindow);
        buttonList.Add(buttonNextOnQuestionsWindow);
        buttonList.Add(buttonReturnOnResultWindow);
        buttonList.Add(buttonExitOnStartWindow);
        buttonList.Add(buttonExitOnResultWindow);
        buttonList.Add(buttonLangOnStartWindow);
        buttonList.Add(buttonReturnOnLanguageWindow);
        buttonList.Add(buttonRusOnLanguageWindow);
        buttonList.Add(buttonEngOnLanguageWindow);
        buttonList.Add(buttonChiOnLanguageWindow);

        foreach (var button in buttonAnswer)
            buttonList.Add(button);
    }




}


