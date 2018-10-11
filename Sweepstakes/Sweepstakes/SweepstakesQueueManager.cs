using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> QueueSweepstakes = new Queue<Sweepstakes>();


            public  Sweepstakes GetSweepstakes( )
            {
                // Remove elements from the queue (first element)
                return(QueueSweepstakes.Dequeue());
             }
            public void InsertSweepstakes(Sweepstakes sweepstakes)
            {
                // Add elements to the queue
                QueueSweepstakes.Enqueue(sweepstakes);

            }


    }
}
