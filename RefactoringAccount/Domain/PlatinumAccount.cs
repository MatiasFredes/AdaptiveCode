using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PlatinumAccount : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Ceiling(
                (Balance / PlatinumBalanceCostPerPoint) + 
                (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
