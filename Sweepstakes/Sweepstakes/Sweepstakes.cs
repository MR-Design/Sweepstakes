using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int counter;
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
             counter = NewContestant.Count;
            contestant.Id += counter;
            Console.Write("Your Registration Number is = {0} ", contestant.Id);
            NewContestant.Add(contestant.Id, contestant);
        }
        public void PickWinner()
        {
            int  winner;
            Random random = new Random();
            winner = random.Next(0, counter);
            Contestant winningContestant = NewContestant[winner];
            PrintContestantInfo(winningContestant);
            Console.Write("The Winner is = {0} ", winningContestant);
            Console.WriteLine();

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(" ID ={0}, First Name ={1}, Last Name = {2}", contestant.Id, contestant.firstName, contestant.lastName);
        }
    }
}
