using System;

namespace Sweepstakes
{
    class Program
    {
        Contestant contestant = new Contestant();
        static void Main(string[] args)
        {
            Sweepstakes WinACar = new Sweepstakes("Win a Car");
            
           
            Contestant a = new Contestant();
            Contestant b = new Contestant();
            Contestant c = new Contestant();


            WinACar.RegisterContestant(a);
            WinACar.RegisterContestant(b);
            WinACar.RegisterContestant(c);

            Console.ReadKey();
           // Console.WriteLine()

        }
    }
}
