using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[SerializeField]
public class Interface : QuestionsDB
{
    public GameObject
    windowStart, windowQuestions, windowResult, windowLanguage;   //windows

    public Button
    buttonStartOnStartWindow, buttonLangOnStartWindow, buttonExitOnStartWindow,                                     //windowStart

    buttonNextOnQuestionsWindow, buttonReturnOnQuestionsWindow, buttonExitOnQuestionsWindow,                        //windowQuestions

    buttonReturnOnResultWindow, buttonExitOnResultWindow,                                                           //windowResult

    buttonReturnOnLanguageWindow, buttonRusOnLanguageWindow, buttonEngOnLanguageWindow, buttonChiOnLanguageWindow;  //windowLanguage

    public Button[] buttonAnswer;                   //windowQuestions

    public Color rightColor, wrongColor;            //windowsQuestions

    public Text
    questionTextField,                              //windowQuestions

    rightAnswerTextField, wrongAnswerTextField;     //windowResult

    public static Color myColor = new Color(255f / 255f, 210f / 255f, 167f / 255f, 1);
    public List<Lang> languageForButton = new List<Lang>();
     
     public string lang = "eng";



    private int _id = 0, _idA;

    private int _countRight, _countWrong;

    private bool _done = false;


    public void ActiveWindows(string window)
    {
        switch (window)
        {
            default:
            case "windowStart":
                windowQuestions.SetActive(false);
                windowResult.SetActive(false);
                windowLanguage.SetActive(false);
                windowStart.SetActive(true);
                break;
            case "windowQuestions":
                windowResult.SetActive(false);
                windowLanguage.SetActive(false);
                windowStart.SetActive(false);
                windowQuestions.SetActive(true);
                break;
            case "windowLanguage":
                windowResult.SetActive(false);
                windowQuestions.SetActive(false);
                windowStart.SetActive(false);
                windowLanguage.SetActive(true);
                break;
            case "windowResult":
                windowQuestions.SetActive(false);
                windowStart.SetActive(false);
                windowLanguage.SetActive(false);
                windowResult.SetActive(true);
                break;
        }

    }

    //  public void ActiveWindows(GameObject window)
    //  {
    //     // windowStart     .SetActive(false);
    //     // windowQuestions .SetActive(false);
    //     // windowResult    .SetActive(false);
    //     // windowLanguage  .SetActive(false);

    //     // window          .SetActive(true); 
    //  }

    public void ToWindowStart() => ActiveWindows("windowStart");

    public void Exit() => Application.Quit();

    public void ToWindowLanguage()
    {
        ActiveWindows("windowLanguage");
        // Language.buttonRusOnLanguageWindow = buttonRusOnLanguageWindow;
        // Language.buttonEngOnLanguageWindow = buttonEngOnLanguageWindow;
        // Language.buttonChiOnLanguageWindow = buttonChiOnLanguageWindow;
        // Language.languageForButton = languageForButton;
        //Language.SelectLang();
    }

    public void ToWindowQuestion()
    {
        ActiveWindows("windowQuestions");
        _done = false;
        _id = 0;
        _countRight = 0;
        _countWrong = 0;
        Shuffle();
        Quest();

    }

    public void Quest()
    {
        if (lang == "eng")
        {
            questionTextField.GetComponent<Text>().text = questions[_id].questionEng;
            _idA = 0;
            foreach (var button in buttonAnswer)
            {
                button.GetComponent<Button>().image.color = Color.white;
                button.GetComponentInChildren<Text>().text = questions[_id].ask[_idA].answerEng;
                _idA++;
            }
        }
        if (lang == "rus")
        {
            questionTextField.GetComponent<Text>().text = questions[_id].questionRus;
            _idA = 0;
            foreach (var button in buttonAnswer)
            {
                button.GetComponent<Button>().image.color = Color.white;
                button.GetComponentInChildren<Text>().text = questions[_id].ask[_idA].answerRus;
                _idA++;
            }
        }
        if (lang == "chi")
        {
            questionTextField.GetComponent<Text>().text = questions[_id].questionChi;
            _idA = 0;
            foreach (var button in buttonAnswer)
            {
                button.GetComponent<Button>().image.color = Color.white;
                button.GetComponentInChildren<Text>().text = questions[_id].ask[_idA].answerChi;
                _idA++;
            }
        }
    }

    public void ToWindowsResult()
    {
        ActiveWindows("windowResult");

        if (lang == "eng")
        {
            rightAnswerTextField.GetComponent<Text>().text = "Right answers: " + _countRight;

            wrongAnswerTextField.GetComponent<Text>().text = "Wrong answers: " + _countWrong;
        }
        else if (lang == "rus")
        {
            rightAnswerTextField.GetComponent<Text>().text = "Правильных ответов: " + _countRight;

            wrongAnswerTextField.GetComponent<Text>().text = "Неправильных ответов: " + _countWrong;

        }
        else if (lang == "chi")
        {
            rightAnswerTextField.GetComponent<Text>().text = "正确答案: " + _countRight;

            wrongAnswerTextField.GetComponent<Text>().text = "错误答案: " + _countWrong;
        }


    }

    public void ButtonPush()
    {
        if (_done == false)
        {
            buttonAnswer[0].GetComponent<Button>().onClick.AddListener(delegate { AnswerCheck(0); });
            buttonAnswer[1].GetComponent<Button>().onClick.AddListener(delegate { AnswerCheck(1); });
            buttonAnswer[2].GetComponent<Button>().onClick.AddListener(delegate { AnswerCheck(2); });
            buttonAnswer[3].GetComponent<Button>().onClick.AddListener(delegate { AnswerCheck(3); });

            buttonNextOnQuestionsWindow.GetComponent<MyEventTrigger>().enabled = false;
            foreach (var button in buttonAnswer)
                button.GetComponent<MyEventTrigger>().enabled = true;

        }
        else if (_done == true)

        {

            buttonNextOnQuestionsWindow.GetComponent<Button>().onClick.AddListener(NextQuestion);
            buttonNextOnQuestionsWindow.GetComponent<MyEventTrigger>().enabled = true;
            foreach (var button in buttonAnswer)
                button.GetComponent<MyEventTrigger>().enabled = false;
        }
        buttonStartOnStartWindow.GetComponent<Button>().onClick.AddListener(ToWindowQuestion);
        buttonExitOnStartWindow.GetComponent<Button>().onClick.AddListener(Exit);
        buttonLangOnStartWindow.GetComponent<Button>().onClick.AddListener(ToWindowLanguage);
        buttonReturnOnLanguageWindow.GetComponent<Button>().onClick.AddListener(ToWindowStart);
        buttonReturnOnResultWindow.GetComponent<Button>().onClick.AddListener(ToWindowStart);
        buttonExitOnResultWindow.GetComponent<Button>().onClick.AddListener(Exit);
        buttonReturnOnQuestionsWindow.GetComponent<Button>().onClick.AddListener(ToWindowStart);
        buttonExitOnQuestionsWindow.GetComponent<Button>().onClick.AddListener(Exit);

        buttonRusOnLanguageWindow.GetComponent<Button>().onClick.AddListener(delegate { MakeLang("rus"); });
        buttonEngOnLanguageWindow.GetComponent<Button>().onClick.AddListener(delegate { MakeLang("eng"); });
        buttonChiOnLanguageWindow.GetComponent<Button>().onClick.AddListener(delegate { MakeLang("chi"); });

    }

    public void AnswerCheck(int number)
    {
        if (questions[_id].ask[number].right == true && _done == false)
        {
            buttonAnswer[number].GetComponent<Button>().image.color = rightColor;
            RightAnswerFX();
            CounterRight(_countRight);
        }
        else if (_done == false)
        {
            buttonAnswer[number].GetComponent<Button>().image.color = wrongColor;
            for (int i = 0; i < questions[_id].ask.Count; i++)
            {

                if (questions[_id].ask[i].right == true)

                    buttonAnswer[i].GetComponent<Button>().image.color = rightColor;
            }
            WrongAnswerFX();
            CounterWrong(_countWrong);
        }

    }

    public void NextQuestion()
    {
        if (_id == questions.Count) ToWindowsResult();
        else
        {
            Quest();
            CounterId(_id);
        }
    }

    public void CounterId(int count)
    {
        if (_done != false)
        {
            this._id = count += 1;
            _done = false;
        }
    }

    public void CounterRight(int count)
    {
        if (_done != true)
        {
            this._countRight = count += 1;
            _done = true;
        }

    }

    public void CounterWrong(int count)
    {
        if (_done != true)
        {
            this._countWrong = count += 1;
            _done = true;
        }

    }


    
    public void MakeLang(string langc)
    {
        lang = langc;
        buttonEngOnLanguageWindow.GetComponent<Button>().image.color = Color.white;
        buttonRusOnLanguageWindow.GetComponent<Button>().image.color = Color.white;
        buttonChiOnLanguageWindow.GetComponent<Button>().image.color = Color.white;

        if (lang == "rus")
        {
            buttonRusOnLanguageWindow.GetComponent<Button>().image.color = myColor;


            int x = 0;
            foreach (var button in languageForButton)
            {


                languageForButton[x].button.GetComponentInChildren<Text>().text = languageForButton[x].rusText;
                ++x;
            }


        }

        if (lang == "eng")

        {
            buttonEngOnLanguageWindow.GetComponent<Button>().image.color = myColor;



            int x = 0;
            foreach (var button in languageForButton)
            {

                languageForButton[x].button.GetComponentInChildren<Text>().text = languageForButton[x].engText;
                ++x;
            }

        }
        if (lang == "chi")

        {
            buttonChiOnLanguageWindow.GetComponent<Button>().image.color = myColor;



            int x = 0;
            foreach (var button in languageForButton)
            {

                languageForButton[x].button.GetComponentInChildren<Text>().text = languageForButton[x].chiText;
                ++x;
            }

        }
    }

}


