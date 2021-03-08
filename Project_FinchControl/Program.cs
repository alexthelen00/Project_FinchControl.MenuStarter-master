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
    // Last Modified: 3/7/2020
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
                Console.WriteLine("\td) Light Alarm System");
                Console.WriteLine("\te) Temperature Alarm System");
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
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        LightAlarmDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        TempAlarmDisplayMenuScreen(finchRobot);
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
            finchRobot.setLED(12, 46, 0);
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

        #region DATA RECORDER

        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;

            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayGetData(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);

        }


        //static double ConvertCelsiusToFahrenheit(double celsiusTemp);
        //{

        //double fahrenheit;

        //double celsius = celsiusTemp;
        

        // fahrenheit = (celsius* 9) / 5 + 32;
         

        //}


        static void DataRecorderDisplayGetData(double[] temperatures)
        {
            DisplayScreenHeader("Show Data");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }

        static void DataRecorderDisplayTable(double[] temperatures)
        {

            //
            //display table headers
            //
            Console.WriteLine(
                "Recording #".PadLeft(15) +
                "Temp".PadLeft(15)
                );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );

            //
            //display table data
            //
            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                (index + 1).ToString().PadLeft(15) +
                temperatures[index].ToString("n2").PadLeft(15)
                );
            }
        }

        static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {

            double[] temperatures = new double[numberOfDataPoints];

            DisplayScreenHeader("Get Data");

            Console.WriteLine($"Number of data points:{numberOfDataPoints}");
            Console.WriteLine($"Data point frequency: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("\tThe Finch robot is ready to begin recording temperature data.");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index]= finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}: {temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);

            }

            Console.WriteLine();
            Console.WriteLine("\tTable of Temperatures");
            Console.WriteLine();
            DataRecorderDisplayTable(temperatures);


            DisplayContinuePrompt();

            return temperatures;

        }

        static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;

            DisplayScreenHeader("Data Point Frequency");

            Console.Write("\tFrequency of data points: ");
            

            //validate user input

            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            DisplayContinuePrompt();

            return dataPointFrequency;


        }




        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;
            string userResponse;

            DisplayScreenHeader("Number of Data Points");

            Console.Write("\tNumber of data points: ");
            userResponse = Console.ReadLine();

            //validate user input

            int.TryParse(userResponse, out numberOfDataPoints);

            DisplayContinuePrompt();

            return numberOfDataPoints;

        }


        #endregion

        #region LIGHT ALARM SYSTEM

        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {
            
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;

            do
            {
                DisplayScreenHeader("Light Alarm Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set Sensors to Monitor");
                Console.WriteLine("\tb) Set Range Type");
                Console.WriteLine("\tc) Set Minimum/Maximun Threshold Value");
                Console.WriteLine("\td) Set Time to Moniter");
                Console.WriteLine("\te) Set Alarm");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                        break;

                    case "b":
                        rangeType = LightAlarmDisplaySetRangeType();
                        break;

                    case "c":
                        minMaxThresholdValue = LightAlarmSetMinMaxThresholdValue(rangeType, finchRobot);
                        break;

                    case "d":
                        timeToMonitor = LightAlarmSetTimeToMonitor();
                        break;

                    case "e":
                        LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);

        }

        static void LightAlarmSetAlarm(
            Finch finchRobot, 
            string sensorsToMonitor, 
            string rangeType, 
            int minMaxThresholdValue, 
            int timeToMonitor)
        {
            int secondsElapsed = 0;
            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;

            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"\tSensors to monitor {sensorsToMonitor}");
            Console.WriteLine("\tRange Type: {0}", rangeType);
            Console.WriteLine("\tMin/Max threshold value: " + minMaxThresholdValue);
            Console.WriteLine($"\tTime to Monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
            {
                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor()) / 2;
                        break;

                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;
                }

                finchRobot.wait(1000);
                secondsElapsed++;

            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }

            DisplayMenuPrompt("Light Alarm");
        }


        static int LightAlarmSetTimeToMonitor()
        {
            int timeToMonitor;
            bool validResponse;

            do
            {

                
                validResponse = true;

                DisplayScreenHeader("\tTime To Monitor");


                //validate value

                Console.Write($"\tTime to Monitor in Seconds:");


                if (!int.TryParse(Console.ReadLine(), out timeToMonitor))
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid number for seconds.");

                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }
                

            } while (!validResponse);


            Console.WriteLine($"\tYou choose {timeToMonitor} seconds. ");
            

            DisplayMenuPrompt("Light Alarm");



            return timeToMonitor;
        }


        static int LightAlarmSetMinMaxThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;
            bool validResponse;

            do
            {
                validResponse = true;

                DisplayScreenHeader("Minimum/Maximum Threshold Value");

                Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
                Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
                Console.WriteLine();

                //validate value

                Console.Write($"\tEnter the {rangeType} light sensor value:");

                if (!int.TryParse(Console.ReadLine(), out minMaxThresholdValue)) 
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid value.");

                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }
                

            } while (!validResponse);

            Console.WriteLine($"\tYou choose {minMaxThresholdValue}. ");

            DisplayMenuPrompt("Light Alarm");



            return minMaxThresholdValue;
        }

        static string LightAlarmDisplaySetSensorsToMonitor()
        {
            string sensorsToMonitor;
            bool validResponse;

            do
            {
                validResponse = true;

                DisplayScreenHeader("Sensors to Monitor");

                Console.Write("\tSensors to Monitor [left, right, both]:");
                sensorsToMonitor = Console.ReadLine().ToLower();



                if (sensorsToMonitor != "left" && sensorsToMonitor != "right" && sensorsToMonitor != "both")
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid answer");

                    
                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }



                //sensorsToMonitor = Console.ReadLine();


            } while (!validResponse);


            DisplayMenuPrompt("Light Alarm");


            return sensorsToMonitor;
        }

        static string LightAlarmDisplaySetRangeType()
        {
            string rangeType;
            bool validResponse;

            do
            {

                validResponse = true;

                DisplayScreenHeader("Range Type");

                Console.Write("\tRange Type [minimum, maximum]:");
                rangeType = Console.ReadLine().ToLower();

                if (rangeType != "minimum" && rangeType != "maximum")
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid answer");


                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }

            } while (!validResponse);

            Console.WriteLine($"\tYou choose {rangeType}. ");

            //rangeType = Console.ReadLine();

            DisplayMenuPrompt("Light Alarm");


            return rangeType;
        }


        #endregion

        #region TEMPERATURE ALARM SYSTEM

        static void TempAlarmDisplayMenuScreen(Finch finchRobot)
        {

            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;

            do
            {
                DisplayScreenHeader("Temperature Alarm Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set Sensors to Monitor");
                Console.WriteLine("\tb) Set Range Type");
                Console.WriteLine("\tc) Set Minimum/Maximun Threshold Value");
                Console.WriteLine("\td) Set Time to Moniter");
                Console.WriteLine("\te) Set Alarm");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = TempAlarmDisplaySetSensorsToMonitor();
                        break;

                    case "b":
                        rangeType = TempAlarmDisplaySetRangeType();
                        break;

                    case "c":
                        minMaxThresholdValue = TempAlarmSetMinMaxThresholdValue(rangeType, finchRobot);
                        break;

                    case "d":
                        timeToMonitor = TempAlarmSetTimeToMonitor();
                        break;

                    case "e":
                        TempAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);

        }

        static void TempAlarmSetAlarm(
            Finch finchRobot,
            string sensorsToMonitor,
            string rangeType,
            int minMaxThresholdValue,
            int timeToMonitor)
        {
            int secondsElapsed = 0;
            bool thresholdExceeded = false;
            int currentTempSensorValue = 0;

            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"\tSensors to monitor {sensorsToMonitor}");
            Console.WriteLine("\tRange Type: {0}", rangeType);
            Console.WriteLine("\tMin/Max threshold value: " + minMaxThresholdValue);
            Console.WriteLine($"\tTime to Monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
            {
                switch (sensorsToMonitor)
                {
                    case "left":
                        currentTempSensorValue = (int)finchRobot.getTemperature();
                        break;

                    case "right":
                        currentTempSensorValue = (int)finchRobot.getTemperature();
                        break;

                    case "both":
                        currentTempSensorValue = (int)((finchRobot.getTemperature() + finchRobot.getTemperature()) / 2);
                        break;

                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentTempSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentTempSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;
                }

                finchRobot.wait(1000);
                secondsElapsed++;

            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentTempSensorValue}.");
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }

            DisplayMenuPrompt("Temp Alarm");
        }


        static int TempAlarmSetTimeToMonitor()
        {
            int timeToMonitor;
            bool validResponse;

            do
            {


                validResponse = true;

                DisplayScreenHeader("\tTime To Monitor");


                //validate value

                Console.Write($"\tTime to Monitor in Seconds:");


                if (!int.TryParse(Console.ReadLine(), out timeToMonitor))
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid number for seconds.");

                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }


            } while (!validResponse);





            DisplayMenuPrompt("Temp Alarm");



            return timeToMonitor;
        }


        static int TempAlarmSetMinMaxThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;
            bool validResponse;

            do
            {
                validResponse = true;

                DisplayScreenHeader("Minimum/Maximum Threshold Value");

                Console.WriteLine($"\tTemp sensor ambient value: {finchRobot.getTemperature()}");
                Console.WriteLine();
                Console.WriteLine($"\tTemp sensor ambient value: {finchRobot.getTemperature()}");
                Console.WriteLine();

                //validate value

                Console.Write($"\tEnter the {rangeType} temp sensor value:");

                if (!int.TryParse(Console.ReadLine(), out minMaxThresholdValue))
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid value.");

                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }


            } while (!validResponse);


            DisplayMenuPrompt("Temp Alarm");



            return minMaxThresholdValue;
        }

        static string TempAlarmDisplaySetSensorsToMonitor()
        {
            string sensorsToMonitor;
            bool validResponse;

            do
            {
                validResponse = true;

                DisplayScreenHeader("Sensors to Monitor");

                Console.Write("\tSensors to Monitor [left, right, both]:");
                sensorsToMonitor = Console.ReadLine().ToLower();



                if (sensorsToMonitor != "left" && sensorsToMonitor != "right" && sensorsToMonitor != "both")
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid answer");


                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }



                //sensorsToMonitor = Console.ReadLine();


            } while (!validResponse);


            DisplayMenuPrompt("Temp Alarm");


            return sensorsToMonitor;
        }

        static string TempAlarmDisplaySetRangeType()
        {
            string rangeType;
            bool validResponse;

            do
            {

                validResponse = true;

                DisplayScreenHeader("Range Type");

                Console.Write("\tRange Type [minimum, maximum]:");
                rangeType = Console.ReadLine().ToLower();

                if (rangeType != "minimum" && rangeType != "maximum")
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("It appears you entered an invalid answer");


                    Console.WriteLine();
                    Console.WriteLine("\tPress any key to continue.");
                    Console.ReadKey();


                }

            } while (!validResponse);



            //rangeType = Console.ReadLine();

            DisplayMenuPrompt("Temp Alarm");


            return rangeType;
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
