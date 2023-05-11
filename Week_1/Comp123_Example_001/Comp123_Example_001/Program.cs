using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Date
{
    private int year;
    private int month;
    private int day;
    public Date(int day = 1, int month = 1, int year = 2022)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }
    public string MonthToEng(int month)
    {
        //return month switch
        //{
        //    1 => "JAN",
        //    2 => "FEB",
        //    3 => "MAR",
        //    4 => "APR",
        //    5 => "MAY",
        //    6 => "JUN",
        //    7 => "JUL",
        //    8 => "AUG",
        //    9 => "SEP",
        //    10 => "OCT",
        //    11 => "NOV",
        //    12 => "DEC",
        //};
        switch (month)
        {
            case 1:
                return "JAN";
            case 2:
                return "FEB";
            case 3:
                return "MAR";
            case 4:
                return "APR";
            case 5:
                return "MAY";
            case 6:
                return "JUN";
            case 7:
                return "JUL";
            case 8:
                return "AUG";
            case 9:
                return "SEP";
            case 10:
                return "OCT";
            case 11:
                return "NOV";
            case 12:
                return "DEC";
            default:
                return "wrong Month input";
        }
    }

    public int DayCount(int month, int year)
    {
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return IsLeapYear(year) ? 29 : 28;
            default:
                return 0;
        }
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 ==0));
    }

    public override string ToString()
    {
        return $"{day}-{MonthToEng(month)}-{year}";
    }
    public void Add(int days)
    {
        day += days;
        Normalize();
    }
    public void Add(int days, int months)
    {
        day += days;
        month += months;
        Normalize();
    }
    public void Add(Date other)
    {
        day += other.day;
        month += other.month;
        year += other.month;
        Normalize();
    }
    private void Normalize()
    {
        while (day > 30)
        {
            month++;
            day -= 30;
        }
        while (month > 12)
        {
            year++;
            month -= 12;
        }
    }

    public void EnhanceDateAdd(int days)
    {
        while (days > 0)
        {
            int nextMonthDay = DayCount(month, year) - day + 1;
            if (days < nextMonthDay)
            {
                day += days;
                break;
            }
            days -= nextMonthDay;
            day = 1;
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
        }
    }

    public static void Main(string[] args)
    {
        Date date_1 = new Date(1, 1, 2000);
        Date date_2 = new Date(1, 1, 2000);
        Date date_3 = new Date(1, 1, 2000);
        Date dateAdd = new Date(3, 3, 3);
        Console.WriteLine("------Using Normal Method------");
        date_1.Add(60);
        Console.WriteLine($"{date_1} (Adding 60 days to 1-JAN-2000)");
        date_2.Add(60, 3);
        Console.WriteLine($"{date_2} (Adding 60 days and 3 Months to 1-JAN-2000)");
        date_3.Add(dateAdd);
        Console.WriteLine($"{date_3} (Adding 3 days, 3 Months and 3 Years to 1-JAN-2000)");
        Console.WriteLine();
        Console.WriteLine("------Using Enhance Method------");
        Date date_4 = new Date(1, 1, 2000);
        Date date_5 = new Date(1, 1, 2000);
        Date date_6 = new Date(1, 1, 2000);
        Date date_7 = new Date(1, 1, 2000);
        date_4.EnhanceDateAdd(60);
        Console.WriteLine($"{date_4} (Adding 60 days to 1-JAN-2000)");
        date_5.EnhanceDateAdd(150);
        Console.WriteLine($"{date_5} (Adding 150 days to 1-JAN-2000)");
        date_6.EnhanceDateAdd(1173);
        Console.WriteLine($"{date_6} (Adding 3 days, 3 Months and 3 Years (3*12+3)*30+33*=1173) to 1-JAN-2000)");
        date_7.EnhanceDateAdd(59);
        Console.WriteLine($"{date_7} (Test For Leap Year)");
    }
}
    