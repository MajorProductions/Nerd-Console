using NerdLib.Console;
using NerdLib.Data;
using NerdLib.Random;

namespace NerdConsole
{
    class Program
    {
        public static string inline = " >> ";
        public static string version = "V 1.0.0.0";
        public static string logType = "";
        public static string logLine = "";

        static void Main(string[] args)
        {
            bool always = true;
            while (always)
            {
                Console.Clear();
                if (logLine != "") { if (logType == "debug") { Log.LogDebug(logLine); } if (logType == "warning") { Log.LogWarning(logLine); } if (logType == "error") { Log.LogError(logLine); } }
                logLine = "";
                int index = 0;
                bool done = false;
                Init();
                Send.Message(" | Greetings User,                                |", false);
                Send.Message(" | What Function Would You Like To Use?           |", false);
                Send.Message(" | ---------------------------------------------- |", false);
                Send.Message(" | 1: Random Number Generator.                    |", false);
                Send.Message(" | 2: Exit Application.                           |", false);
                Send.Message(" | ---------------------------------------------- |", false);
                done = false;
                while (!done)
                {
                    index = Input.RequestInt(" Choice >> ");
                    if (index == 1) { RandomNumber(); done = true; }
                    else if (index == 2) { Console.Quit(); done = true; }
                    else { Console.Beep(); logLine = "That is not a valid index!"; logType = "error"; done = true; }
                }
            }


        }

        static void Init()
        {
            True.SetKey("d627f22b-4a9d-4b3e-8883-05471e87e11f");
            Color.Background(Color.Colors.Black);
            Color.Foreground(Color.Colors.Gray);
            Console.Title("Nerd Console");
        }

        static void RandomNumber()
        {
            bool gen = true;
            while (gen)
            {
                Console.Clear();
                if (logLine != "") { if (logType == "debug") { Log.LogDebug(logLine); } if (logType == "warning") { Log.LogWarning(logLine); } if (logType == "error") { Log.LogError(logLine); } }
                logLine = "";
                int index = 0;
                bool done = false;
                Send.Message(" | Random Number                                  |", false);
                Send.Message(" | ---------------------------------------------- |", false);
                Send.Message(" | 1: Psuedo Random Generator.                    |", false);
                Send.Message(" | 2: Unique Psuedo Random Generator.             |", false);
                Send.Message(" | 3: True Random Generator.                      |", false);
                Send.Message(" | 4: Back.                                       |", false);
                Send.Message(" | ---------------------------------------------- |", false);
                while (!done)
                {
                    index = Input.RequestInt(" Choice >> ");
                    if (index == 1) { /*GetNumber*/ Console.Beep(); logLine = "Not Yet implemented"; logType = "warning"; done = true; }
                    else if (index == 2) { /*GetNumber*/ Console.Beep(); logLine = "Not Yet implemented"; logType = "warning"; done = true; }
                    else if (index == 3) { /*GetNumber*/ Console.Beep(); logLine = "Not Yet implemented"; logType = "warning"; done = true; }
                    else if (index == 4) { gen = false; done = true; }
                    else { Console.Beep(); logLine = "That is not a valid index!"; logType = "error"; done = true; }
                }
            }
        }
    }
}
