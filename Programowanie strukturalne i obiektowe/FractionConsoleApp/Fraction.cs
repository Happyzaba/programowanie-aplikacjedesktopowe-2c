using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionConsoleApp
{
    public class Fraction
    {
        private int numerator;      //licznik
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;    //mianownik
        public int Denomiantor
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    throw new ArgumentException("Nie można wstawiać 0");
            }
        }

        public Fraction()
        {
            Numerator = 0;
            Denomiantor = 1;
        }

        public Fraction(int n, int d)
        {
            Numerator = n;
            Denomiantor = d;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        public void Mul(Fraction firstFraction, Fraction secondFraction)
        {
            Numerator = firstFraction.Numerator * secondFraction.Numerator;
            Denomiantor = firstFraction.Denomiantor * secondFraction.Denomiantor;
        }

        public Fraction Mul(Fraction secondFraction)
        {
            Fraction fraction = new Fraction();
            fraction.Mul(this, secondFraction);
            return fraction;
        }
    }
}