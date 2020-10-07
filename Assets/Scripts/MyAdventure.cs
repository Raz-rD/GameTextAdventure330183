using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        deeltadres,
        nacht,
        checksloten,
        einde_dood,
    }

    private States currentstate = States.start;
    // Start is called before the first frame update
    void Start()
    {
        print(message: "Hello world!");
        Terminal.WriteLine("in de terminal");
        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom");
        Terminal.WriteLine("typ 'start' om te beginnen.");



    }

    void OnUserInput(string input)
    {
        if (currentstate == States.start)
            if (input == "start")
            {
                currentstate = States.intro1;
                StartIntro();
            }
            else if (input == "1337")
            {
                Terminal.WriteLine("jij bent leet!");

            }
            else
            {
                Terminal.WriteLine("verkeerde invoer");

            }

    }

    void StartIntro()
    {

        Terminal.ClearScreen();
        Terminal.WriteLine("...");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
