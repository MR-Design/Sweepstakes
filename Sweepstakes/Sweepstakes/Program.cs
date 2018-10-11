using System;

namespace Sweepstakes
{
    class Program
    {
        Contestant contestant = new Contestant();
        

        static void Main(string[] args)
        {
            

            Sweepstakes WinSomething = new Sweepstakes("Win Somthing");
            Contestant x = new Contestant();
            Contestant y = new Contestant();

            WinSomething.RegisterContestant(x);
            WinSomething.RegisterContestant(y);
            Console.WriteLine();

            WinSomething.PrintContestantInfo(x);

            SweepstakesManager manager = new SweepstakesManager();
            MarketingFirm manage = new MarketingFirm(manager.GetSweepstakes());

        }
    }
}
