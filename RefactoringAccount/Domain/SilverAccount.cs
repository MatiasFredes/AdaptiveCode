using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class SilverAccount : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor(amount / SilverTransactionCostPerPoint), 0);
        }

        private const int SilverTransactionCostPerPoint = 10;
    }
}
