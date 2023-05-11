using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W8_Account_2
{
    public class AccountException : Exception
    {
        public const string ACCOUNT_DOES_NOT_EXIST = "Account Not Exist!";
        public const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "Exceeded Credit Limit!";
        public const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "Account Name not associated!";
        public const string NO_OVERDRAFT = "No overdraft!";
        public const string PASSWORD_INCORRECT = "Incorrect Password!";
        public const string USER_DOES_NOT_EXIST = "User does not exist!";
        public const string USER_NOT_LOGGED_IN = "User Not Login!";

        public AccountException() { }
        public AccountException(string reason) : base(reason)
        {

        }
    }
}
