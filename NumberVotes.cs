using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal class NumberVotes
    {
        static int totalVotes;
        static int totalVotesII;
        public static void Total()
        {
            Design.Line();
            Console.Write("\t\tTotal Number of Votes: ");
            totalVotes = Convert.ToInt32(Console.ReadLine());
            Design.Line();
        }
        public static void TotalII()
        {
            Design.Line();
            Console.Write("\t\tTotal Number of Votes: ");
            totalVotesII = Convert.ToInt32(Console.ReadLine());
            Design.Line();
        }
    }
}
