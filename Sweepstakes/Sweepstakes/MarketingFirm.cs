using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public  ISweepstakesManager _SweepstakesManagerType;
        public MarketingFirm(ISweepstakesManager SweepstakesManagerType)
        {
            SweepstakesManagerType = _SweepstakesManagerType;
        }
        public void Use(ISweepstakesManager _SweepstakesManagerType, Sweepstakes sweepstakes )
        {
            _SweepstakesManagerType.GetSweepstakes();
            _SweepstakesManagerType.InsertSweepstakes(sweepstakes);
        }
    }
}
