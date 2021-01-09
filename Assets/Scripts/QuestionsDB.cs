using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class QuestionsDB : MonoBehaviour
{
    public List<Question> questions = new List<Question>();

    public List<Lang> langs = new List<Lang>();

    public bool lang = false;



    public void QuestionsInitDB()
    {
      
        //////////////
        questions[0].questionRus = "Чтобы скачать Unity Personal на компьютер необходимо:";
        questions[0].ask[0].answerRus = "оплачивать абонплату 15$ в месяц";
        questions[0].ask[1].answerRus = "оплачивать всего 35$ в год";
        questions[0].ask[2].answerRus = "внести разовый платеж 10$ за скачивание и дальше использовать программу без ограничений";
        questions[0].ask[3].answerRus = "это полностью бесплатная версия, не требующая оплаты, если Ваши доходы от разработки не выше 100000$";

        questions[0].questionEng = "To download Unity Personal to your computer you need to:";
        questions[0].ask[0].answerEng = "pay a subscription fee of $15 per month";
        questions[0].ask[1].answerEng = "pay only $35 a year";
        questions[0].ask[2].answerEng = "make a one-time payment of $10 for downloading and continue to use the program without restrictions";
        questions[0].ask[3].answerEng = "this is a completely free version that does not require payment, if your income from development is not higher than $100,000";

        questions[0].ask[3].right = true;
        //////////////
        questions[1].questionRus = "Чтобы установить Unity на компьютер необходимо:";
        questions[1].ask[0].answerRus = "на всех дисках - по 10 ГБ свободого места";
        questions[1].ask[1].answerRus = "не менее 30 ГБ свободного места на диске С://";
        questions[1].ask[2].answerRus = "не менее 25 ГБ свободного места на любом диске";
        questions[1].ask[3].answerRus = "не менее 50 ГБ свободного места на диске D://";

        questions[1].questionEng = "To install Unity on your computer, you must:";
        questions[1].ask[0].answerEng = "10 GB of free space on all disks";
        questions[1].ask[1].answerEng = "at least 30 GB of free disk space C://";
        questions[1].ask[2].answerEng = "at least 25 GB of free space on any disk";
        questions[1].ask[3].answerEng = "at least 50 GB of free space on disk D://";

        questions[1].ask[1].right = true;
        //////////////
        questions[2].questionRus = "Unity позволяет создавать:";
        questions[2].ask[0].answerRus = "игры для телефонов, ПК и серверные игры";
        questions[2].ask[1].answerRus = "игры для запуска на iOS и Android";
        questions[2].ask[2].answerRus = "любые игры, а также графику для кинематографических и анимационных проектов";
        questions[2].ask[3].answerRus = "любые игры разного уровня сложности";
        
questions[2].questionEng = "Unity allows you to create:";
        questions[2].ask[0].answerEng = "games for phones, PCs and server games";
        questions[2].ask[1].answerEng = " games to run on iOS and Android";
        questions[2].ask[2].answerEng = " any games, as well as graphics for cinematic and animation projects";
        questions[2].ask[3].answerEng = " any games of different difficulty levels";
        
        questions[2].ask[2].right = true;
        //////////////
        questions[3].questionRus = "Чтобы установить последнюю версию Unity, рекомендуется использовать:";
        questions[3].ask[0].answerRus = "телефон iPhone или Samsung последних моделей (512GB, Оперативная память: 4 Гб)";
        questions[3].ask[1].answerRus = "компьютер Версия OS: Ubuntu 18.10";
        questions[3].ask[2].answerRus = "компьютер Версия OS: Windows 7 SP1+, 8, 10, 64-bit versions only; macOS 10.12+";
        questions[3].ask[3].answerRus = "любой компьютер, планшет или ноутбук";

        questions[3].questionEng = " To install the latest version of Unity, we recommend using:";
        questions[3].ask[0].answerEng = " Latest iPhone or Samsung phone (512GB, RAM: 4GB)";
        questions[3].ask[1].answerEng = "computer OS version: Ubuntu 18.10";
        questions[3].ask[2].answerEng = " computer OS version: Windows 7 SP1+, 8, 10, 64-bit versions only; mac OS 10.12+";
        questions[3].ask[3].answerEng = " any computer, tablet or laptop";

        questions[3].ask[2].right = true;
        //////////////
        questions[4].questionRus = "Графику для игр на Unity...";
        questions[4].ask[0].answerRus = "можно использовать собственную или из наборов Asset Store, но с других сторонних сайтов запрещено";
        questions[4].ask[1].answerRus = "рекомендуется всегда рисовать самостоятельно";
        questions[4].ask[2].answerRus = "рекомендуется всегда добавлять из библиотеки Unity Asset Store, чтобы не было ошибок";
        questions[4].ask[3].answerRus = "можно использовать любую графику: собственную, из наборов Asset Store или с других сайтов";

        questions[4].questionEng = " Graphics for games on Unity...";
        questions[4].ask[0].answerEng = " you can use your own or from Asset Store sets, but from other third-party sites is prohibited";
        questions[4].ask[1].answerEng = " it is always recommended to draw yourself";
        questions[4].ask[2].answerEng = " it is recommended to always add from the Unity Asset Store library, so that there are no errors";
        questions[4].ask[3].answerEng = " you can use any graphics: your own, from Asset Store sets, or from other sites";

        questions[4].ask[3].right = true;
        //////////////
        questions[5].questionRus = "Unity - это...";
        questions[5].ask[0].answerRus = "логотип, которым отмечают качественные игры";
        questions[5].ask[1].answerRus = "название компьютерной игры";
        questions[5].ask[2].answerRus = "название компании, занимающейся разработкой игр";
        questions[5].ask[3].answerRus = "среда разработки компьютерных игр";

        questions[5].questionEng = " Unity is...";
        questions[5].ask[0].answerEng = " logo that marks quality games";
        questions[5].ask[1].answerEng = " name of the computer game";
        questions[5].ask[2].answerEng = " name of the game development company";
        questions[5].ask[3].answerEng = " computer game development environment";

        questions[5].ask[3].right = true;
        //////////////
        questions[6].questionRus = "Чтобы создавать игры на Unity обязательно нужно:";
        questions[6].ask[0].answerRus = "просто придумать идею хорошей игры";
        questions[6].ask[1].answerRus = "освоить интерфейс программы и можно приступать к разработке";
        questions[6].ask[2].answerRus = "уметь создавать графику для игр";
        questions[6].ask[3].answerRus = "уметь писать скрипты на языке С#";

        questions[6].questionEng = " To create games on Unity, you must:";
        questions[6].ask[0].answerEng = " just come up with an idea for a good game";
        questions[6].ask[1].answerEng = " master the program interface and you can start developing";
        questions[6].ask[2].answerEng = " be able to create graphics for games";
        questions[6].ask[3].answerEng = " be able to write scripts in C#";

        questions[6].ask[3].right = true;
        //////////////
        questions[7].questionRus = "Освоить разработку игр на Unity...";
        questions[7].ask[0].answerRus = "очень простая задача, особенно для начинающих";
        questions[7].ask[1].answerRus = "очень сложная задача, особенно для начинающих";
        questions[7].ask[2].answerRus = "простая задача, если обучатся систематически, с помощью книг, уроков или видеокурсов";
        questions[7].ask[3].answerRus = "можно только с помощью персонального преподавателя";

        questions[7].questionEng = " Learn to develop games on Unity ...";
        questions[7].ask[0].answerEng = " very simple task, especially for beginners";
        questions[7].ask[1].answerEng = " very difficult task, especially for beginners";
        questions[7].ask[2].answerEng = " a simple task if you learn systematically, using books, lessons or video courses";
        questions[7].ask[3].answerEng = " only possible with the help of a personal teacher";

        questions[7].ask[2].right = true;
        //////////////
        questions[8].questionRus = "Если игра принесла доход от 100 до 200 тысяч долларов, то нужно:";
        questions[8].ask[0].answerRus = "заплатить компании Unity Technologies 1500$";
        questions[8].ask[1].answerRus = "заплатить государству налоги";
        questions[8].ask[2].answerRus = "заплатить компании Unity Technologies 420$";
        questions[8].ask[3].answerRus = "наслаждаться - взять шампанское и отпраздновать!";

        questions[8].questionEng = " If the game brought income from 100 to 200 thousand dollars, then you need:";
        questions[8].ask[0].answerEng = " pay Unity Technologies $1500";
        questions[8].ask[1].answerEng = " pay taxes to the state";
        questions[8].ask[2].answerEng = " pay Unity Technologies $420";
        questions[8].ask[3].answerEng = " enjoy-take champagne and celebrate!";

        questions[8].ask[2].right = true;


    }

    public void Shuffle()
    {
        questions = questions.OrderBy(p => Guid.NewGuid()).ToList();
        foreach (var r in questions)
        {
            r.ask = r.ask.OrderBy(p => Guid.NewGuid()).ToList();
        }

    }
}


