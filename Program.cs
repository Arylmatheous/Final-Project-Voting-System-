using System;

namespace Voting_System
{
    class Program
    {
        //static string winner = null;
        //static int maximumVotes = -1;
        static void Main(string[] args)
        {
            Precinct.Inputting();
            Candidates.NamesAndVotes();
            Precinct.InputtingII();
            Candidates.NamesAndVotesII();
            Candidates.AddingVotes();



        }

    }
}