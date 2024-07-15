using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal class Candidates
    {
        // Gagamit ng Dictionary... Nag-i-store ito ng data in a pair...
        static List<string> Candidate = new List<string>();
        static Dictionary<string, int> votes = new Dictionary<string, int>();
        static string candidateName;

        // Dapat yung winner na variable is wala pang laman...
        static string winner = null;
        static int maximumVotes = -1;

        public static void NamesAndVotes()
        {
            bool A = true;

            while (true)
            {
                Precinct.Number();
                Design.Line();
                Instructions.Candidate();
                Instructions.DirectionII();
                Design.Line();
                Console.Write("\t\tEnter the name of the candidate: ");
                candidateName = Console.ReadLine();
                Console.Clear();

                if (candidateName.ToLower() == "done")
                {
                    break;
                }

                Candidate.Add(candidateName);
                votes[candidateName] = 0;
            }

            Precinct.Number();
            Design.Line();
            Console.WriteLine("\t\tThe list of candidates:");
            foreach (string candidate in Candidate)
            {
                Console.WriteLine($"\t\t* {candidate}");
            }

            NumberVotes.Total();
            Instructions.Vote();
            Design.Line();

            while (true)
            {
                Console.Write("\t\tCandidate: ");
                candidateName = Console.ReadLine();

                if (candidateName.ToLower() == "done")
                {
                    break;
                }

                if (votes.ContainsKey(candidateName))
                {
                    votes[candidateName]++;
                }
                else
                {
                    Console.WriteLine("\t\tThis vote is invalid.");
                }
            }
            Console.Clear();

            winner = null;
            maximumVotes = -1;

            foreach (var vote in votes)
            {
                if (vote.Value > maximumVotes)
                {
                    maximumVotes = vote.Value;
                    winner = vote.Key;
                }
            }

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine("\t\tResult:");
            Design.Line();

            foreach (var vote in votes)
            {
                Console.WriteLine($"\t\t{vote.Key}: {vote.Value} vote(s)");
            }

            Design.Line();
            Console.WriteLine("\t\tDecision:");
            Console.WriteLine($"\t\tThe winner in this precinct is: {winner} with {maximumVotes} votes");
            Design.Line();
            Greetings.Thanks();
            Design.Line();
            Design.ArrowDown();
        }
        // Uulitin yung whole process sa susunod na method...
        // Ipag-a-add lahat ng votes (both precinct) and then saka i-d-display yung winner!!!

        static List<string> CandidateII = new List<string>();
        static Dictionary<string, int> votesII = new Dictionary<string, int>();
        static string candidateNameII;

        static string winnerII = null;
        static int maximumVotesII = -1;

        public static void NamesAndVotesII()
        {
            bool B = true;
            while (true)
            {
                Precinct.NumberII();
                Design.Line();
                Instructions.Candidate();
                Instructions.DirectionIII();
                Design.Line();
                Console.Write("\t\tEnter the name of the candidate: ");
                candidateNameII = Console.ReadLine();
                Console.Clear();

                if (candidateNameII.ToLower() == "done")
                {
                    break;
                }

                CandidateII.Add(candidateNameII);
                votesII[candidateNameII] = 0;
            }

            Precinct.NumberII();
            Design.Line();
            Console.WriteLine("\t\tThe list of candidates:");
            foreach (string candidateII in CandidateII)
            {
                Console.WriteLine($"\t\t* {candidateII}");
            }

            NumberVotes.TotalII();
            Instructions.Vote();
            Design.Line();

            while (true)
            {
                Console.Write("\t\tCandidate: ");
                candidateNameII = Console.ReadLine();

                if (candidateNameII.ToLower() == "done")
                {
                    break;
                }

                if (votesII.ContainsKey(candidateNameII))
                {
                    votesII[candidateNameII]++;
                }
                else
                {
                    Console.WriteLine("\t\tThis vote is invalid.");
                }
            }
            Console.Clear();

            winnerII = null;
            maximumVotesII = -1;

            foreach (var voteII in votesII)
            {
                if (voteII.Value > maximumVotesII)
                {
                    maximumVotesII = voteII.Value;
                    winnerII = voteII.Key;
                }
            }

            Design.Line();
            Greetings.Greet();
            Design.Line();
            Console.WriteLine("\t\tResult:");
            Design.Line();

            foreach (var voteII in votesII)
            {
                Console.WriteLine($"\t\t{voteII.Key}: {voteII.Value} vote(s)");
            }

            Design.Line();
            Console.WriteLine("\t\tDecision:");
            Console.WriteLine($"\t\tThe winner in this precinct is: {winnerII} with {maximumVotesII} votes");
            Design.Line();
            Greetings.Thanks();
            Design.Line();
            Design.ArrowDown();
        }

        static Dictionary<string, int> result = new Dictionary<string, int>();
        public static void AddingVotes()
        {
            foreach (var candidateVote in votes.Keys)
            {
                if (votesII.ContainsKey(candidateVote))
                {
                    result[candidateVote] = votes[candidateVote] + votesII[candidateVote] ;
                }
            }

            Design.Line();
            Console.WriteLine("\t\tOverall Results:");
            Design.Line();
            foreach (var grandWinner in result)
            {
                Console.WriteLine($"\t\tThe overall votes of the is: {grandWinner.Key}: {grandWinner.Value}");
            }

            // Need kong ma-display yung may highest value ng Value and yung corresponding Key nito...
            int highestVote = result.Values.Max();

            string winningCandidate = result.FirstOrDefault(value => value.Value == highestVote).Key;

            Design.Line();
            Console.WriteLine("\t\tDecision:");
            Console.WriteLine($"\t\tThe winner in this vote is: {winningCandidate} with {highestVote} votes");
            Design.Line();
            Greetings.Thanks();
            Design.Line();
        }
    }
}
