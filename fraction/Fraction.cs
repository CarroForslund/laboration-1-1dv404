using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            getNumerator = numerator;
            getDenominator = denominator;
            
            //Console.WriteLine("Ditt bråktal är {0}/{1}", numerator, denominator);
        }

        public int getNumerator
        {
            //int numerator = ReadInt("Ange nämnare: ");
            get { return _numerator; }
            set
            {
                _numerator = value;
            }
        }

        public int getDenominator
        {
            get { return _denominator; }
            set
            {
                _denominator = value;
            }
        }

        public bool isNegative(int numerator, int denominator)
        {
            if (numerator < 0 || denominator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fraction add(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.getDenominator == fraction2.getDenominator)
            {
                return new Fraction(fraction1.getNumerator + fraction2.getNumerator, fraction1.getDenominator);
            }
            else
            {
                //int numerator1 = fraction1.getNumerator * fraction2.getDenominator;
                //int denomerator1 = fraction1.getDenominator * fraction2.getDenominator;
                //+
                //fraction2.getNumerator * fraction1.getDenominator
                //fraction2.getDenominator * fraction1.getDenominator
                return new Fraction(((fraction1.getNumerator * fraction2.getDenominator) + (fraction2.getNumerator * fraction1.getDenominator)), (fraction1.getDenominator * fraction2.getDenominator));
            }
            
        }

        public Fraction multiply(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.getNumerator * fraction2.getNumerator, fraction1.getDenominator * fraction2.getDenominator);
        }

        public bool isEqualTo(Fraction fraction1, Fraction fraction2)
        {
            if ((fraction1.getNumerator / fraction1.getDenominator) == (fraction2.getNumerator / fraction2.getDenominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", getNumerator, getDenominator);
        }

        
    }
}