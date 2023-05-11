using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W9__Lab_Calculator
{
    public class Fraction
    {
        public int Top { get;}
        public int Bottom { get;}
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        public Fraction(string top = "0", string bottom = "1")
        {
            Top = Convert.ToInt32(top);
            Bottom = Convert.ToInt32(bottom);
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int sumTop = left.Top * right.Bottom + right.Top * left.Bottom;
            int sumBottom = left.Bottom * right.Bottom;
            return new Fraction(sumTop, sumBottom);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            int subTop = left.Top * right.Bottom - right.Top * left.Bottom;
            int subBottom = left.Bottom * right.Bottom;
            return new Fraction(subTop, subBottom);
            ////if (subTop < 0)
            ////{
            ////    throw new Exception("The result is negative.");
            ////}
            //try
            //{
            //    if (subTop < 0)
            //    {
            //        throw new Exception("The result is negative.");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //return new Fraction(subTop, subBottom);
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            int sumTop = left.Top *  right.Top;
            int sumBottom = left.Bottom * right.Bottom;
            return new Fraction(sumTop, sumBottom);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            int sumTop = left.Top * right.Bottom;
            int sumBottom = left.Bottom * right.Top;
            return new Fraction(sumTop, sumBottom);
        }

        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }

        public void Deconstruct(out string top, out string bottom)
      => (top, bottom) = ($"{Top}", $"{Bottom}");

    }
}
