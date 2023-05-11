using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W8_Account_2
{
    struct Transaction
    {
        public string AccountNumber { get; }
        public double Amount { get; }
        public double EndBalance { get; }
        public Person Originator { get; }
        public DateTime Time { get; }
        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }
        public override string ToString()
        {
            //Deposit or Withdraw
            return $"Account Number: [{AccountNumber}] Name: {Originator} Amount: {Amount} Transition time:{Time.ToShortTimeString()} ";
        }
    }
}
