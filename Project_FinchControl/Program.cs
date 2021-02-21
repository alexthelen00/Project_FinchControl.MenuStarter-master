using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Thelen, Alex
    // Dated Created: 2/17/2020
    // Last Modified: 2/17/2020
    //
    // **************************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance");
                Console.WriteLine("\tc) Mixing It Up");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "d":

                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }



            //LONDON BRIDGE IS FALLING DOWN

            finchRobot.setLED(75, 0, 30);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(880);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(300);

            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(500);

            //FALLING DOWN, FALLING DOWN

            finchRobot.setLED(255, 0, 0);

            finchRobot.noteOn(587);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(689);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(500);

            //LONDON BRIDGE IS FALLING DOWN

            finchRobot.setLED(75, 0, 30);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(880);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(357);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(300);

            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();


            //LONDON BRIDGE IS FALLING DOWN

            finchRobot.setLED(75, 0, 30);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(880);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(300);

            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(500);

            //FALLING DOWN, FALLING DOWN

            finchRobot.setLED(255, 0, 0);

            finchRobot.noteOn(587);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(689);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(375);

            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(500);

            //LONDON BRIDGE IS FALLING DOWN

            finchRobot.setLED(75, 0, 30);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(880);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(357);

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.wait(300);

            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();

            finchRobot.setLED(0, 0, 0);

            
            DisplayMenuPrompt("Talent Show Menu");
        }




        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Dance                  *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayDance(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Dance");

            Console.WriteLine("\tThe Finch robot will now show off its dance moves!");
            DisplayContinuePrompt();

            finchRobot.setLED(0, 255, 0);
            finchRobot.setMotors(150, 150);
            finchRobot.wait(1000);
            finchRobot.setMotors(150, 255);
            finchRobot.wait(500);
            finchRobot.setLED(255, 0, 0);
            finchRobot.setMotors(150, 150);
            finchRobot.wait(1000);
            finchRobot.setMotors(255, 150);
            finchRobot.wait(500);
            finchRobot.setLED(0, 0, 255);
            finchRobot.setMotors(150, 150);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(2000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(12, 45, 0);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(2000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 255, 0);
            finchRobot.setMotors(150, 150);
            finchRobot.wait(1000);
            finchRobot.setMotors(150, 255);
            finchRobot.wait(500);
            finchRobot.setLED(255, 0, 78);
            finchRobot.setMotors(150, 150);
            finchRobot.wait(1000);
            finchRobot.setMotors(255, 150);
            finchRobot.wait(500);
            finchRobot.setLED(0, 56, 255);
            finchRobot.setMotors(150, 150);
            finchRobot.setMotors(255, -255);
            finchRobot.wait(2000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(12, 45, 124);
            finchRobot.setMotors(-255, 255);
            finchRobot.wait(2000);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);


            DisplayMenuPrompt("Talent Show Menu");
        }



        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Mixing it Up                  *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Mixing it Up");

            Console.WriteLine("\tThe Finch robot will now show off its talent!");
            DisplayContinuePrompt();

            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 127, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 255, 0);
            finchRobot.wait(1000); 
            finchRobot.setLED(0, 255, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(1000);
            finchRobot.setLED(75, 0, 30);
            finchRobot.wait(1000);
            finchRobot.setLED(148, 0, 211);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 127, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 255, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 255, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(1000);
            finchRobot.setLED(75, 0, 30);
            finchRobot.wait(1000);
            finchRobot.setLED(148, 0, 211);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 0, 0);

            finchRobot.noteOn(523);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(587);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(659);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(698);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(784);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(880);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(988);
            finchRobot.wait(250);
            finchRobot.noteOff();
            finchRobot.noteOn(1047);
            finchRobot.wait(250);
            finchRobot.noteOff();
            

            for (int ledValue = 0; ledValue < 255; ledValue++)
            {
                finchRobot.setLED(ledValue, ledValue, ledValue);
                finchRobot.wait(20);

            }

            for (int ledValue = 0; ledValue > 255; ledValue--)
            {
                finchRobot.setLED(ledValue, ledValue, ledValue);
                finchRobot.wait(20);

            }

            finchRobot.setLED(0, 0, 0);

            DisplayMenuPrompt("Talent Show Menu");
        }


        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
