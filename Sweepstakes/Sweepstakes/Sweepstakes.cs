using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {

        public Dictionary<int, Contestant> NewContestant = new Dictionary<int, Contestant>();
        string name;

        public string Name { get { return name; } }

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        


        public void RegisterContestant(Contestant contestant)
        {
            contestant.Infos();
            int amount = NewContestant.Count;
            contestant.Id += amount;
            Console.Write(" your Registration Number is = {0} ", contestant.Id);
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
            winner = random.Next(0, 100000);
            Contestant winningContestant = NewContestant[winner];
            PrintContestantInfo(winningContestant);
        }


        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(" ID ={0}, First Name ={1}, Last Name = {2}", contestant.Id, contestant.firstName, contestant.lastName);
        }
    }
}
