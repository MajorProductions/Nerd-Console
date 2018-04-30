using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Console
{
    class Program
    {
        private static bool canParse = new bool();
        private static List<int> optionContainer = new List<int>();
        private static int returnedOption = new int();

        static void Main(string[] args)
        {
            Console.WriteLine("Please wait for further development...");
            Console.ReadLine();

            bool canParse = false;
            optionContainer.Add(1);
            returnedOption = 0;

            while (!canParse || !optionContainer.Contains(returnedOption))
            {
                Console.Clear();
                Console.WriteLine("\n Please Enter The Index Of The Function You Wish To Run... ");
                Console.WriteLine(" 1: Close Application. ");
                Console.WriteLine("\n___________________________________________________________"); // Length of longest string!
                canParse = int.TryParse(Console.ReadLine(), out int result);
                returnedOption = result;
            }
            
            switch (returnedOption)
            {
                case 1:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
