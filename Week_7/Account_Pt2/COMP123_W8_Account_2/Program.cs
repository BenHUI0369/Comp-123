namespace COMP123_W8_Account_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing the visa account
            Console.WriteLine("\nAll acounts:");
            Bank.PrintAccounts();
            Console.WriteLine("\nAll Users:");
            Bank.PrintPersons();

            Person p0, p1, p2, p3, p4, p5, p6, p7, p8;
            p0 = Bank.GetPerson("Narendra");
            p1 = Bank.GetPerson("Ilia");
            p2 = Bank.GetPerson("Tom");
            p3 = Bank.GetPerson("Syed");
            p4 = Bank.GetPerson("Arben");
            p5 = Bank.GetPerson("Patrick");
            p6 = Bank.GetPerson("Yin");
            p7 = Bank.GetPerson("Hao");
            p8 = Bank.GetPerson("Jake");

            p0.Login("123"); p1.Login("234");
            p2.Login("345"); p3.Login("456");
            p4.Login("567"); p5.Login("678");
            p6.Login("789"); p7.Login("890");

            //a visa account
            VisaAccount a = (VisaAccount)Bank.GetAccount("VS-100000");
            a.DoPayment(1500, p0);
            a.DoPurchase(200, p1);
            a.DoPurchase(25, p2);
            a.DoPurchase(15, p0);
            a.DoPurchase(39, p1);
            a.DoPayment(400, p0);
            Console.WriteLine(a);

            a = (VisaAccount)Bank.GetAccount("VS-100001");
            a.DoPurchase(25, p3);
            a.DoPurchase(20, p4);
            a.DoPurchase(15, p2);
            a.DoPayment(400, p0);
            Console.WriteLine(a);

            //a saving account
            SavingAccount b = (SavingAccount)Bank.GetAccount("SV-100002");
            b.Withdraw(300, p0);
            b.Withdraw(32.90, p6);
            b.Withdraw(50, p5);
            b.Withdraw(111.11, p5);
            Console.WriteLine(b);

            b = (SavingAccount)Bank.GetAccount("SV-100003");
            b.Deposit(300, p3);     //ok even though p3 is not a holder
            b.Deposit(32.90, p2);
            b.Deposit(50, p5);
            b.Withdraw(111.11, p5);
            Console.WriteLine(b);

            //a checking account
            CheckingAccount c = (CheckingAccount)Bank.GetAccount("CK-100005");
            c.Deposit(33.33, p7);
            c.Deposit(40.44, p7);
            c.Withdraw(450, p5);
            c.Withdraw(500, p5);
            c.Withdraw(645, p5);
            c.Withdraw(850, p6);
            Console.WriteLine(c);

            c = (CheckingAccount)Bank.GetAccount("CK-100004");
            c.Deposit(33.33, p7);
            c.Deposit(40.44, p7);
            c.Withdraw(150, p5);
            c.Withdraw(200, p7);
            c.Withdraw(645, p7);
            c.Withdraw(350, p5);
            Console.WriteLine(c);

            Console.WriteLine("\n\nExceptions:");
            //The following will cause exception
            try
            {
                p8.Login("911");//incorrect password
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                p3.Logout();
                a.DoPurchase(12.5, p3);     //exception user is not logged in
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                a.DoPurchase(12.5, p0); //user is not associated with this account
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                a.DoPurchase(5825, p2); //credit limit exceeded
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }
            try
            {
                c.Withdraw(1500, p5); //no overdraft
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                Bank.GetAccount("CK-100008"); //account does not exist
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                Bank.GetPerson("Trudeau"); //user does not exist
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }
            Console.WriteLine("\nBefore PrepareMonthlyReport()");
            Console.WriteLine(c);

            Console.WriteLine("\nAfter PrepareMonthlyReport()");
            c.PrepareMonthlyReport();   //all transactions are cleared, balance changes
            Console.WriteLine(c);

        }
    }
}