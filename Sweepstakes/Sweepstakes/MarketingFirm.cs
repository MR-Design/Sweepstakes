using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        private ISweepstakesManager _SweepstakesManagerType;
        public MarketingFirm(ISweepstakesManager SweepstakesManagerType)
        {
            SweepstakesManagerType = _SweepstakesManagerType;
        }
        public void Use()
        { 
        }

    }
}
