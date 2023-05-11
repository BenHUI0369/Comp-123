using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W8_Account_2
{
    class Person
    {
        private string password;
        public readonly string SIN;
        public bool IsAuthentivated { get; private set; }
        public string Name { get; }
        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            password = SIN.Substring(0, 3);
        }
        public void Login(string password)
        {
            if (this.password != password)
            {
                throw new AccountException("Password Not match!");
            }
            else
            {
                IsAuthentivated = true;
            }
        }
        public void Logout()
        {
            IsAuthentivated = false;
        }
        public override string ToString()
        {
            string authenticated = IsAuthentivated ? "Yes" : "No";
            return $"Name: {Name} Authenticated:{authenticated} ";
        }
    }
}
