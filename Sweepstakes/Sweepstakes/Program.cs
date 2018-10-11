using System;

namespace Sweepstakes
{
    class Program
    {
        Contestant contestant = new Contestant();
        static void Main(string[] args)
        {
            Sweepstakes WinSothing = new Sweepstakes("Win Somthing");
            Contestant aa = new Contestant();
            Contestant bb = new Contestant();
            Contestant cc = new Contestant();
            WinSothing.RegisterContestant(aa);
            WinSothing.RegisterContestant(bb);
            WinSothing.RegisterContestant(cc);
            Console.WriteLine();

            SweepstakesManager sweepstakesManager = new SweepstakesManager();


        }
    }
}
