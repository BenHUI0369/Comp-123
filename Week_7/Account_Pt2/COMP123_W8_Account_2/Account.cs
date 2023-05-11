using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace COMP123_W8_Account_2
{
    abstract class Account
    {
        private static int CURRENT_NUMBER = 100000;
        protected List<Transaction> transactions = new List<Transaction>();
        protected List<Person> holders = new List<Person>();
        public readonly string Number;
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }
        public Account(string type, double balance)
        {
            Balance += balance;
            LowestBalance += balance;
            Number = type + CURRENT_NUMBER;
            CURRENT_NUMBER++;
        }
        public void AddUser(Person person)
        {
            holders.Add(person);
        }
        public void Deposit(double amount, Person person)
        {
            Balance += amount;
            LowestBalance += amount;

            //string accountNumber, double amount, double endBalance, Person person, DateTime tim
            Transaction newTransactions = new Transaction(Number, amount, Balance, person, DateTime.Now);
            transactions.Add(newTransactions);
        }
        public bool IsHolder(string name)
        {
            //bool isHolder = false;
            //for (int i = 0; i < holders.Count; i++)
            //{
            //    if (holders[i].Name == name)
            //    {
            //        isHolder = true;
            //        return isHolder;
            //    }
            //    else
            //    {
            //        isHolder = false;
            //        return isHolder;
            //    }
            //}
            //return isHolder;
            bool isHolder = false;
            for (int i = 0; i < holders.Count; i++)
            {
                if (holders[i].Name == name)
                {
                    isHolder = true;
                    break;
                }
            }
            return isHolder;
        }
        public abstract void PrepareMonthlyReport();

        public override string ToString()
        {
            string displayResult;
            displayResult = $"AccountNumber: [{Number}]\n";
            for (int i = 0; i < holders.Count; i++)
            {
                displayResult += $"User: {holders[i].Name}\n";
            }
            displayResult += $"Balance: [{Balance}]\n";
            for (int i = 0; i < transactions.Count; i++)
            {
                displayResult += $"Transactions: {transactions[i]}\n";
            }
            return displayResult;

        }
    }
}
