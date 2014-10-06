﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinerControl.PriceEntries
{
    public class WafflePoolPriceEntry : PriceEntryBase
    {
        public WafflePoolPriceEntry()
        {
            Service = ServiceEnum.WafflePool;
        }

        public override decimal Fees
        {
            get { return Earn * 0.02m; }
            set { base.Fees = value; }
        }
    }
}
