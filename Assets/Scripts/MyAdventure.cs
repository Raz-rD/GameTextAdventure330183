using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // verschillende states in de game
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        nacht,
        checksloten,
        ramen,
        zaklamp,
        woonkamer,
        slaapkamer,
        seinen,
        verstoppenbed,
        doorhetraam,
        verstoppenbadkamer,
        verstoppenwoonkamer,
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Write("Welkom bij HorrorNite");
        Write("Dit is gebasseerd op een waargebeurd verhaal");
        Write("Typ start om te beginnen");
    }

    void StartIntro1()
    {
        currentState = States.intro1;
        Terminal.ClearScreen();
        Write("Het was een koude donkere nacht, en je bent alleen thuis.");
        Write("Dat zorgt voor het ultieme moment om ongestoord Fortnite te doen");
        Write("Typ verder om door te gaan");
    }

    void StartIntro2()
    {
        currentState = States.intro2;
        Terminal.ClearScreen();
        Write("Na een paar potjes begin je bekend te raken met een andere speler.");
        Write("Je begint erg gewaagd te raken aan hem, maar vind de uitdaging ook erg leuk.");
        Write("Typ verder om door te gaan");
    }

    void Delen()
    {
        currentState = States.delen;
        Terminal.ClearScreen();
        Write("Deze speler zou graag jou op Discord willen toevoegen, om nog meer potjes samen te kunnen doen");
        Write("Zou jij hem willen toevoegen?");
        Write("Typ ja om gegevens te delen, of nee om deze niet te delen");
    }

    void Deelnee()
    {
        currentState = States.deelnee;
        Terminal.ClearScreen();
        Write("Je besloot niet te delen.");
        Write("Toch kreeg je ineens een friendrequest binnen. Je accepteert deze.");
        Write("Typ verder om door te gaan");
    }

    void Deelja()
    {
        currentState = States.deelja;
        Terminal.ClearScreen();
        Write("Je besloot te delen.");
        Write("Je krijgt een friendrequest binnen. Je accepteert deze.");
        Write("Typ verder om door te gaan");
    }

    void LeukGesprek()
    {
        currentState = States.leukgesprek;
        Terminal.ClearScreen();
        Write("Je hebt een leuk gesprek met je nieuwe vriend.");
        Write("Hij vraagt je om je adres. Aangezien je hem wel vetrouwd, geef jij dit aan hem.");
        Write("Typ 'verder' om door te gaan.");
    }

    void Nacht()
    {
        currentState = States.nacht;
        Terminal.ClearScreen();
        Write("het is ondertussen al nacht.");
        Write("het is al donker buiten.");
        Write("Typ 'verder' om door te gaan.");
    }

    void CheckSloten()
    {
        currentState = States.checksloten;
        Terminal.ClearScreen();
        Write("Je krijgt een beetje een naar gevoel.");
        Write("Check jij je sloten?");
        Write("Typ 'ja' om ze te checken, typ 'nee' om niets te doen.");
    }

    void Ramen()
    {
        currentState = States.ramen;
        Terminal.ClearScreen();
        Write("Je denkt ineens aan de ramen.");
        Write("Check je de ramen?");
        Write("Typ 'ja' om de ramen te checken, typ 'nee' om dit niet te doen.");
    }

    void Zaklamp()
    {
        currentState = States.ramen;
        Terminal.ClearScreen();
        Write("het stroom valt ineens uit en je raakt in paniek.");
        Write("Je zoekt naar een zaklamp.");
        Write("Waar zoek je eerst?");
        Write("Typ 'woonkamer' om in de woonkamer te zoeken, typ 'slaapkamer' om in de slaapkamer te zoeken.");
    }

    void Woonkamer()
    {
        currentState = States.woonkamer;
        Terminal.ClearScreen();
        Write("Je zoekt de hele woonkamer door maar je kan niets vinden. Je gaat toch naar je slaapkamer om daar te zoeken.");
        Write("Typ 'verder' om door te gaan.");
    }

    void Slaapkamer()
    {
        currentState = States.slaapkamer;
        Terminal.ClearScreen();
        Write("Terwijl je naar de slaapkamer loopt om de zaklamp te pakken hoor je ineens een raam breken.");
        Write("Wat doe je?");
        Write("Typ 'seinen' om naar de buren te seinen, typ 'verstoppen' om je onder het bed te verstoppen");
    }

        void Seinen()
        {
            currentState = States.seinen;
            Terminal.ClearScreen();
            Write("Je seint naar de buren.");
            Write("Gelukkig zijn je buren nog wakker, die je seinen ontvangen en de politie belt.");
            Write("De inbreker wordt opgepakt en je overleeft!");
            Write("Typ 'restart' om overnieuw te beginnen.");
        }

        void VerstoppenBed()
        {
            currentState = States.verstoppenbed;
            Terminal.ClearScreen();
            Write("Je besloot om je te verstoppen onder je bed.");
            Write("Dit was niet een heel verstandige keuze, want dit is een populaire verstopplek.");
            Write("De inbreker vind je en steekt je dood.");
            Write("Typ 'restart' om overnieuw te beginnen.");
        }

        void DoorHetRaam()
        {
            currentState = States.doorhetraam;
            Terminal.ClearScreen();
            Write("Er komt iemand door de ramen naar binnen.");
            Write("je raakt in paniek en besluit jezelf ergens te verstoppen.");
            Write("waar wil je je verstoppen?");
            Write("Typ 'Slaapkamer' om je in de slaapkamer te verstoppen, 'woonkamer' om je in de woonkamer te verstoppen en 'badkamer' om je in de badkamer te verstoppen.");
        }

        void VerstoppenWoonkamer()
        {
            currentState = States.verstoppenwoonkamer;
            Terminal.ClearScreen();
            Write("Je heb besloten om je achter de gordijnen in de woonkamer te verstoppen.");
            Write("De inbreker verwachtte dit al, en kijkt hier als eerst. Wanneer hij jou ziet steekt hij je gelijk neer.");
            Write("Typ 'restart' om overnieuw te beginnen.");
        }

        void VerstoppenBadkamer()
        {
            currentState = States.verstoppenbadkamer;
            Terminal.ClearScreen();
            Write("Je heb besloten om in de badkuip in de badkamer te verstoppen.");
            Write("je hoort de inbreker door het huis lopen, maar hij checkt gelukkig niet in de badkamer");
            Write("je hoort de inbreker het huis uit gaan en je komt de badkamer weer uit.");
            Write("Hoera! je leeft nog.");
            Write("Typ 'restart' om overnieuw te beginnen.");
        }


        void Write(string tekst)
        {
            Terminal.WriteLine(tekst);
        }

        void OnUserInput(string input)
        {
            switch (currentState)
            {
                case States.start:
                    if (input == "start")
                    {
                        StartIntro1();
                    }
                    else if (input == "1337")
                    {
                        Write("Jij bent leet!");
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.intro1:
                    if (input == "verder")
                    {
                        StartIntro2();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.intro2:
                    if (input == "verder")
                    {
                        Delen();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.delen:
                    if (input == "ja")
                    {
                        Deelja();
                    }
                    else if (input == "nee")
                    {
                        Deelnee();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.deelja:
                    if (input == "verder")
                    {
                        LeukGesprek();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.deelnee:
                    if (input == "verder")
                    {
                    LeukGesprek();
                    }
                    else
                    {
                    Write("Dat commando bestaat niet");
                    }
                    break;
                 case States.leukgesprek:
                    if (input == "verder")
                    {
                        Nacht();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                    case States.nacht:
                    if (input == "verder")
                    {
                    CheckSloten();
                    }
                    else
                    {
                    Write("Dat commando bestaat niet");
                    }
                    break;
                case States.checksloten:
                    if (input == "ja")
                    {
                        DoorHetRaam();
                    }
                    else if (input == "nee")
                    {
                        Ramen();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.doorhetraam:
                    if (input == "slaapkamer")
                    {
                        VerstoppenBed();
                    }
                    else if (input == "woonkamer")
                    {
                        VerstoppenWoonkamer();
                    }
                    else if (input == "badkamer")
                    {
                        VerstoppenBadkamer();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.verstoppenbed:
                    if (input == "restart")
                    {
                        ShowMainMenu();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.verstoppenwoonkamer:
                    if (input == "restart")
                    {
                        ShowMainMenu();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.verstoppenbadkamer:
                    if (input == "restart")
                    {
                        ShowMainMenu();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.ramen:
                    if (input == "ja")
                    {
                        Zaklamp();
                    }
                    else if (input == "nee")
                    {
                        DoorHetRaam();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.zaklamp:
                    if (input == "woonkamer")
                    {
                        Woonkamer();
                    }
                    else if (input == "slaapkamer")
                    {
                        Slaapkamer();
                    }
                    else
                    {
                        Write("Dat commando bestaat niet");
                    }
                    break;
                case States.woonkamer:
                    if (input == "verder") 
                    {
                    Slaapkamer();
                    }
                    else
                    {
                    Write("Dat commando bestaat niet");
                    }
                    break;
                case States.slaapkamer:
                    if (input == "verstoppen")
                    {
                    VerstoppenBed();
                    }
                    else if (input == "seinen")
                    {
                    Seinen();
                    }
                    else
                    {
                    Write("Dat commando bestaat niet");
                    }
                    break;
                case States.seinen:
                    if (input == "restart")
                    {
                    ShowMainMenu();
                    }
                    else
                    {
                    Write("Dat commando bestaat niet");
                    }
                    break;




            default:
                    Debug.Log("Er gaat iets fout");
                    break;
            }

        }
        // Update is called once per frame
        void Update()
        {
            Debug.Log(currentState);
        }
    } 
