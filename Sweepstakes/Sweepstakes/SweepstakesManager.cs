using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesManager
    {
        public string Input;
        public ISweepstakesManager GetSweepstakes()
        {
            Console.WriteLine(" [Q] Get By SweepstakesQueueManager /n1. [S] Get By SweepstakesStackManager / n2");
            Input = Console.ReadLine();
            switch (Input)
            {
                case "Q":
                    return new SweepstakesQueueManager();
                case "S":
                    return new SweepstakesStackManager();
               
                default:
                    throw new ApplicationException(string.Format("Not a valid Choice"));
            }
        }
        public ISweepstakesManager InsertSweepstakes()
        {
            Console.WriteLine(" [Q] Insert by SweepstakesQueueManager /n1. [S] Insert By SweepstakesStackManager / n2");
            Input = Console.ReadLine();
            switch (Input)
            {
                case "Q":
                    return new SweepstakesQueueManager();
                case "S":
                    return new SweepstakesStackManager();

                default:
                    throw new ApplicationException(string.Format("Not a valid Choice"));
            }
        }
    }
}
