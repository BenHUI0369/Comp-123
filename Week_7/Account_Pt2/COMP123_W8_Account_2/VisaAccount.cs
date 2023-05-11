using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W8_Account_2
{
    class VisaAccount : Account
    {
        private static double INTEREST_RATE = 0.1995;
        private double credLimit;

        public VisaAccount(double balance = 0, double creditLimit = 1200):base("VS-", balance)
        {

        }
        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        /*
        public void DoPurchase(double amount, Person person)
        {
            for (int i = 0; i < base.holders.Count; i++)
            {
                if (base.holders[i].Name != person.Name)
                {
                    throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
                }
                else if (person.IsAuthentivated != true)
                {
                    throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
                }
                else if (amount > base.Balance)
                {
                    throw new AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
                }
                else
                {
                    Deposit(amount, person);
                }
            }
        }
        */
        public void DoPurchase(double amount, Person person)
        {
            bool isAuthorized = false;
            for (int i = 0; i < base.holders.Count; i++)
            {
                if (base.holders[i].Name == person.Name)
                {
                    if (person.IsAuthentivated != true)
                    {
                        throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
                    }
                    else if (amount > base.Balance)
                    {
                        throw new AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
                    }
                    else
                    {
                        isAuthorized = true;
                        break;
                    }
                }
            }
            if (!isAuthorized)
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            Deposit(amount, person);
        }

        public override void PrepareMonthlyReport()
        {
            double interest = Balance * INTEREST_RATE / 12;
            Balance += interest;
            transactions.Clear();
        }
    }
}
