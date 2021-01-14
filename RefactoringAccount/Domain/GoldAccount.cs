using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class GoldAccount : Account
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor((Balance / GoldBalanceCostPerPoint) +
                (amount / GoldTransactionCostPerPoint)), 0);
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;

        public GoldAccount()
        {
        }
    }
}
