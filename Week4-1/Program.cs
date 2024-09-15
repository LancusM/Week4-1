using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_1
{
    internal class Program
    {
        //It all works, although I hope it is in the way that you want, at least it's working as intended, which works for moi.
        public static void DisplayResults(Dictionary<string, int> candidates)
        {
            //checks if a candidate recieved ANY votes, and if so, display the amount
            if (candidates["Candidate 1"] > 0 )
            {
                Console.WriteLine("Candidate 1 recieved " + candidates["Candidate 1"] + " votes.");
            }
            if (candidates["Candidate 2"] > 0)
            {
                Console.WriteLine("Candidate 2 recieved " + candidates["Candidate 2"] + " votes.");
            }
            if (candidates["Candidate 3"] > 0)
            {
                Console.WriteLine("Candidate 3 recieved " + candidates["Candidate 3"] + " votes.");
            }
            if (candidates["Candidate 4"] > 0)
            {
                Console.WriteLine("Candidate 4 recieved " + candidates["Candidate 4"] + " votes.");
            }
        }
        public static void CastVote(string candidateName, Dictionary<string, int> candidates)
        {
            //takes the candidates and adds to their dictionary value if a vote has been given to them, which is displayed in DispalyResults().
            if (candidateName == "Candidate 1")
            {
                candidates["Candidate 1"] += 1;
            }
            else if (candidateName == "Candidate 2")
            {
                candidates["Candidate 2"] += 1;
            }
            else if (candidateName == "Candidate 3")
            {
                candidates["Candidate 3"] += 1;
            }
            else if (candidateName == "Candidate 4")
            {
                candidates["Candidate 4"] += 1;
            }
        }
        public static void ResetVotes(Dictionary<string, int> candidates)
        {
            //The ResetVotes method that I definitely didn't forget was necessary!
            candidates.Clear();
            candidates.Add("Candidate 1", 0);
            candidates.Add("Candidate 2", 0);
            candidates.Add("Candidate 3", 0);
            candidates.Add("Candidate 4", 0);
        }
        //Main fucntion
        static void Main(string[] args)
        {
            /* I remembered last second that the Reset needed to go through the method, so I think I made it work, but other than a while loop with the method,
             * I don't know how to have it loop back to the start. */
            string resetString = "Y";
            while (resetString != "N")
            { 
                //Asks user for input on their vote.
            Console.WriteLine("Voting System");
            Console.WriteLine("Vote for a candidate by entering their number (1-4) .");
            Console.WriteLine("Vote for: ");
            int vote = Convert.ToInt32(Console.ReadLine());

                //Dictionary declares candidate name and vote amount. I wanted it to be outside of it all, so they all could pull from it, but I didn't work it out, but this works well.
            Dictionary<string, int> candidates = new Dictionary<string, int>();
            candidates.Add("Candidate 1", 0);
            candidates.Add("Candidate 2", 0);
            candidates.Add("Candidate 3", 0);
            candidates.Add("Candidate 4", 0);
                
                //I knew a while statement would work for the loop to function, but I found a switch statement to work best for me so each vote would push into one candidate.
                while (vote > 0 && vote < 5)
                {
                    switch (vote)
                    {
                        //each case of user input gives a vote to the resppective candidate
                       case 1:
                          CastVote("Candidate 1", candidates);
                          break;
                       case 2:
                         CastVote("Candidate 2", candidates);
                         break;
                       case 3:
                           CastVote("Candidate 3", candidates);
                           break;
                       case 4:
                           CastVote("Candidate 4", candidates);
                           break;
                    }
                
                    //looping text to re-input a vote until the loop breaks off
                    Console.WriteLine("Vote for: ");
                vote = Convert.ToInt32(Console.ReadLine());
                }
            //votes display automatically once voting it over, and then is prompted to go again or reset
            DisplayResults(candidates);

            Console.WriteLine("Do you want to reset the votes? Y/N");
                resetString = Console.ReadLine();
                ResetVotes(candidates);
                //The reset went through the while loop, and I believe the method functions as it should, but that one I understood the least. I still get it, though.
            }
        }
    }
}
