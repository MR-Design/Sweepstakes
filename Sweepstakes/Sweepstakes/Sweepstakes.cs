using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> NewContestant = new Dictionary<int, Contestant>();


        Sweepstakes(string name) // Tirages au Sort
        {

  
        }





        void RegisterContestant(Contestant contestant)
        {
            contestant.Infos();
            NewContestant.Add(contestant.Id, contestant);
            




            // The Add method throws an exception if the new key is already in the dictionary.
            //try
            //{
            //    NewContestant.Add(, "");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("An element with Key = \"contestant.Id\" already exists.");
            //}
        }


        public void PickWinner()
        {
            int  winner;

            //  random number who define infos from  ID
            Random random = new Random();
            winner = random.Next(2018, 3018);
            Contestant winningContestant = NewContestant[winner];
            PrintContestantInfo(winningContestant);
        }


        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(" ID ={0}, First Name ={1}", contestant.Id, contestant.firstName);
        }
    }
}
