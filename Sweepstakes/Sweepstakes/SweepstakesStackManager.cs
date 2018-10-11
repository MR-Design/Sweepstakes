using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesStackManager: ISweepstakesManager
    {
        Stack<Sweepstakes> StackSweepstakes = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            // remove item from the Stack (last element)
            return(StackSweepstakes.Pop());
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            // add items to the Stack
            StackSweepstakes.Push(sweepstakes);
      
        }
    }
}
