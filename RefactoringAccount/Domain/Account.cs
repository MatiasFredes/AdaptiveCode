using System;

namespace Domain
{
    public abstract class Account
    {
        public virtual decimal Balance
        {
            get;
            private set;
        }

        public int RewardPoints
        {
            get;
            private set;
        }

        public Account()
        {
           
        }

        public void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }

        public abstract int CalculateRewardPoints(decimal amount);
        

       

       
    }
}
