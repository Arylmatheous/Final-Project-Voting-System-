using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal class Precinct
    {
        static string precinctNumber;
        static string precinctNumberII;
        public static void Inputting()
        {
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.Write("\t\tEnter the precinct number: ");
            precinctNumber = Console.ReadLine();
            Console.Clear();
        }

        public static void Number()
        {
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumber}");
        }

        public static void InputtingII()
        {
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.Write("\t\tEnter another precinct number: ");
            precinctNumberII = Console.ReadLine();
            Console.Clear();
        }

        public static void NumberII()
        {
            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine($"\t\tPrecinct Number: {precinctNumberII}");
        }
    }
}
