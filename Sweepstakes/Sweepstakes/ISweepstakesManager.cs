using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
        Sweepstakes GetSweepstakes();
         void InsertSweepstakes(Sweepstakes sweepstakes);    

    }
}
