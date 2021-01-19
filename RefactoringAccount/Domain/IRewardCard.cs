using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IRewardCard
    {
        public int RewardPoints
        {
            get;
        }

        int CalculateRewardPoints(decimal amount);

    }
}
