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

        public static Account CreateAccount(AccountType type)
        {
            Account account = null;

            switch (type)
            {
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Gold:
                    account = new GoldAccount();
                    break;
                case AccountType.Platinum:
                    account = new PlatinumAccount();
                    break;
            }

            return account;
        }
    }
}
