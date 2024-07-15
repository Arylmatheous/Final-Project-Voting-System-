using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal class Instructions
    {
        public static void Direction()
        {
            Console.WriteLine("\t\tInstruction:");
            Console.WriteLine($"\t\tEnter 1 to vote for Candidate A");
            Console.WriteLine($"\t\tEnter 2 to vote for Candidate B");
            Console.WriteLine($"\t\tEnter 3 to vote for Candidate C");
            Console.WriteLine($"\t\tEnter 4 to vote for Candidate D");
        }

        public static void Candidate()
        {
            Console.WriteLine("\t\tInstruction:");
            Console.WriteLine("\t\tEnter the names of the candidates and type 'done' to finish:");
        }

        public static void Vote()
        {
            Console.WriteLine("\t\tInstruction:");
            Console.WriteLine("\t\tEnter the votes for each candidates and type 'done' to finish:");
        }

        public static void DirectionII()
        {
            Console.WriteLine("\t\tNOTE: "); 
            Console.WriteLine("\t\tThe order of the candidates you inputted in this precinct must be in the same order");
            Console.WriteLine("\t\tin the next precinct!!!");
        }

        public static void DirectionIII()
        {
            Console.WriteLine("\t\tNOTE: ");
            Console.WriteLine("\t\tThe order of the candidates you inputted in this precinct must be in the same order");
            Console.WriteLine("\t\tin the next precinct!!!");
        }
    }
}
