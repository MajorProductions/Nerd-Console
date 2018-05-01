using NerdLib.Console;
using NerdLib.Data;
using NerdLib.Random;

namespace NerdConsole
{
    class Program
    {
        public static string inline = " >> ";
        public static string version = "V 1.0.0.0";

        static void Main(string[] args)
        {

            Console.Title("Nerd Console " + version);
            Color.Background(Color.Colors.Black);
            Color.Foreground(Color.Colors.Green);

            Send.Message("This is a message", true);
            Send.Message("This message is in blue", Color.Colors.Blue);

            string tempfloat = Input.RequestBool("You saw that right?" + inline).ToString();
            Send.Message("You said " + tempfloat + "!", true);
        }
    }
}
