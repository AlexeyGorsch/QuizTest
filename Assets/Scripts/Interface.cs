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

[SerializeField]
//public class Interface : MonoBehaviour
public class Interface : QuestionsDB
{

    //public Question[] questions;
    public Button buttonStart, buttonNext, buttonReturn, buttonExit, buttonExitInResult, buttonExitInQuestions, buttonReturnInQuestions;

    public Text questionTextField, rightAnswerTextField, wrongAnswerTextField;
    public Button[] buttonAnswer;

    public GameObject windowStart, windowQuestions, windowResult;

    private int _id = 0;
    private int _countRight, _countWrong;
    private bool _done = false;

    public int Id { get => _id; set => _id = value; }
    public bool Done { get => _done; set => _done = value; }
    public int CountRight { get => _countRight; set => _countRight = value; }
    public int CountWrong { get => _countWrong; set => _countWrong = value; }

    public void Run()
    {
        ActiveWindows(true, false, false);
        buttonStart.GetComponent<Button>().onClick.AddListener(Load);
        buttonExit.GetComponent<Button>().onClick.AddListener(Exit);
        SelectLang();
    }

    public void Load()
    {
        ActiveWindows(false, true, false);
        _id = 0;
        _countRight = 0;
        _countWrong = 0;
        Shuffle();
        Quest();
    }
    public void Quest()
    {

        switch (lang)
        {
            case true:
                questionTextField.GetComponent<Text>().text = questions[_id].questionRus;

                int i = 0;
                foreach (var button in buttonAnswer)
                {
                    button.GetComponent<Button>().image.color = Color.white;
                    button.GetComponentInChildren<Text>().text = questions[_id].ask[i].answerRus;
                    ++i;
                }
                break;
            case false:
            default:
                questionTextField.GetComponent<Text>().text = questions[_id].questionEng;

                int c = 0;
                foreach (var button in buttonAnswer)
                {
                    button.GetComponent<Button>().image.color = Color.white;
                    button.GetComponentInChildren<Text>().text = questions[_id].ask[c].answerEng;
                    ++c;
                }
                break;
        }
        buttonReturnInQuestions.GetComponent<Button>().onClick.AddListener(Return);
        buttonExitInQuestions.GetComponent<Button>().onClick.AddListener(Exit);

    }

    public void Result()
    {

        if (lang == false)
        {
            rightAnswerTextField.GetComponent<Text>().text = "Right answers: " + _countRight;

            wrongAnswerTextField.GetComponent<Text>().text = "Wrong answers: " + _countWrong;
        }
        else if (lang == true)
        {
            rightAnswerTextField.GetComponent<Text>().text = "Правильных ответов: " + _countRight;

            wrongAnswerTextField.GetComponent<Text>().text = "Неправильных ответов: " + _countWrong;
        }

        ActiveWindows(false, false, true);
        buttonReturn.GetComponent<Button>().onClick.AddListener(Return);
        buttonExitInResult.GetComponent<Button>().onClick.AddListener(Exit);

    }
    public void Return()
    {
        ActiveWindows(true, false, false);

    }
    public void Exit()
    {
        Application.Quit();
    }


    public void ButtonPush()
    {

        if (_done == false)
        {
            buttonAnswer[0].GetComponent<Button>().onClick.AddListener(delegate { Answer(0); });
            buttonAnswer[1].GetComponent<Button>().onClick.AddListener(delegate { Answer(1); });
            buttonAnswer[2].GetComponent<Button>().onClick.AddListener(delegate { Answer(2); });
            buttonAnswer[3].GetComponent<Button>().onClick.AddListener(delegate { Answer(3); });

        }
        else if (_done == true)

            buttonNext.GetComponent<Button>().onClick.AddListener(NextQuestion);

    }

    public void Answer(int number)
    {
        if (questions[_id].ask[number].right == true && _done == false)
        {
            buttonAnswer[number].GetComponent<Button>().image.color = rightColor;
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
            CounterWrong(_countWrong);
        }
    }

    public void NextQuestion()
    {
        if (_id == questions.Count) Result();
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

    public void ActiveWindows(bool start, bool questions, bool result)
    {
        this.windowStart.SetActive(start);
        this.windowQuestions.SetActive(questions);
        this.windowResult.SetActive(result);
    }


    public Button rus, eng;

    public Color myColor, rightColor, wrongColor;



    public void SelectLang()
    {
        myColor = new Color(255f / 255f, 210f / 255f, 167f / 255f, 1);
        lang = false;

        rus.GetComponent<Button>().onClick.AddListener(delegate { lang = true; MakeLang(); });
        eng.GetComponent<Button>().onClick.AddListener(delegate { lang = false; MakeLang(); });

    }
    public void MakeLang()
    {

        if (lang == true)
        {
            Debug.Log("true");
            rus.GetComponent<Button>().image.color = myColor;
            eng.GetComponent<Button>().image.color = Color.white;

            int x = 0;
            foreach (var button in langs)
            {

                langs[x].button.GetComponentInChildren<Text>().text = langs[x].RusText;
                ++x;
            }


        }

        if (lang == false)

        {
            Debug.Log("false"); eng.GetComponent<Button>().image.color = myColor;
            rus.GetComponent<Button>().image.color = Color.white;


            int x = 0;
            foreach (var button in langs)
            {

                langs[x].button.GetComponentInChildren<Text>().text = langs[x].EngText;
                ++x;
            }

        }
    }
}

