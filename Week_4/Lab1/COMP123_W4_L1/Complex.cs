using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W4_L1
{
    public class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument
        {
            get 
            {
                return Math.Sqrt(Real * Real + Imaginary * Imaginary); 
            }
        }
        public double Modulus
        {
            get
            {
                return Math.Atan(Imaginary / Real);
            }
        }
        public static Complex Zero 
        {
            get
            {
                return new Complex(0, 0);
            }
            
        }

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"Real: {Real} Imaginary: {Imaginary}";
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            bool real = lhs.Real == rhs.Real;
            bool imaginary = lhs.Imaginary == rhs.Imaginary;
            bool compare = real && imaginary;
            return compare;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            bool real = lhs.Real != rhs.Real;
            bool imaginary = lhs.Imaginary != rhs.Imaginary;
            bool compare = real && imaginary;
            return compare;
        }

        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = (lhs.Real * rhs.Real) - (lhs.Imaginary * rhs.Imaginary);
            int imaginary = (lhs.Real * rhs.Imaginary) + (lhs.Imaginary * rhs.Real);
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs)
        {
            int real = -lhs.Real;
            int imaginary = -lhs.Imaginary;
            return new Complex(real, imaginary);
        }
    }
}
