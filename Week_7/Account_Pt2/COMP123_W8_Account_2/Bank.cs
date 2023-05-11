using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP123_W8_Account_2
{
    class Bank
    {
        static private List<Account> accounts;
        static private List<Person> persons;

        static Bank()
        {
            Initialize();
        }

        static void CreatePersons()
        {
            persons = new List<Person>(){
            new Person("Narendra", "1234-5678"),
            new Person("Ilia", "2345-6789"),
            new Person("Tom", "3456-7890"),
            new Person("Syed", "4567-8901"),
            new Person("Arben", "5678-9012"),
            new Person("Patrick", "6789-0123"),
            new Person("Yin", "7890-1234"),
            new Person("Hao", "8901-2345"),
            new Person("Jake", "9012-3456")
            };
        }

        static void CreateAccounts()
        {
            accounts = new List<Account>{
            new VisaAccount(),              //VS-100000
            new VisaAccount(550, -500),     //VS-100001
            new SavingAccount(5000),        //SV-100002
            new SavingAccount(),            //SV-100003
            new CheckingAccount(2000),      //CK-100004
            new CheckingAccount(1500, true) //CK-100005
            };
        }

        static void Initialize()
        {
            CreateAccounts();
            CreatePersons();
            accounts[0].AddUser(persons[0]);
            accounts[0].AddUser(persons[1]);
            accounts[0].AddUser(persons[2]);

            accounts[1].AddUser(persons[3]);
            accounts[1].AddUser(persons[4]);
            accounts[1].AddUser(persons[2]);

            accounts[2].AddUser(persons[0]);
            accounts[2].AddUser(persons[5]);
            accounts[2].AddUser(persons[6]);

            accounts[3].AddUser(persons[5]);
            accounts[3].AddUser(persons[6]);

            accounts[4].AddUser(persons[5]);
            accounts[4].AddUser(persons[7]);
            accounts[4].AddUser(persons[8]);

            accounts[5].AddUser(persons[5]);
            accounts[5].AddUser(persons[6]);
        }

        public static void PrintAccounts()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine(accounts[i]);
            }
        }

        public static void SaveAccounts(string filename)
        {
            string jsonString = JsonSerializer.Serialize(accounts);
            File.WriteAllText(filename, jsonString);
        }

        public static void PrintPersons()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i]);
            }
        }

        public static  Person GetPerson(string name)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Name == name)
                {
                    return persons[i];
                }
            }
            throw new AccountException(AccountException.USER_DOES_NOT_EXIST);
        }

        public static Account GetAccount(string number)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Number == number)
                {
                    return accounts[i];
                }
            }
            throw new AccountException(AccountException.ACCOUNT_DOES_NOT_EXIST);
        }
    }
}
