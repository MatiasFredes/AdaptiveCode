using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IAccountFactory
    {
        Account CreateAccount(AccountType type);
    }
}
