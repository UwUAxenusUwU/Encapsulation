using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();
            //fraction.INTEGER = 2;
            //fraction.NUMERATOR = 3;
            //fraction.DENOMINATOR = 4;
            fraction1.Input();
            fraction1.print();
            fraction2.Input();
            fraction2.print();
            Console.Clear();
            Fraction fraction3 = fraction1 + fraction2;
            Console.WriteLine("Sum result: "); fraction3.print();
            Fraction fraction4 = fraction1 - fraction2;
            Console.WriteLine("Difference result: "); fraction4.print();
            Fraction fraction5 = fraction1 * fraction2;
            Console.WriteLine("Multiplication result: "); fraction5.print();
            Fraction fraction6 = fraction1 / fraction2;
            Console.WriteLine("Devision result: "); fraction6.print();

        }
    }
    class Fraction
    {
        //int integer, numerator, denominator;
        public int INTEGER { get; set; }    
        public int NUMERATOR { get; set; }
        public int DENOMINATOR { get; set; }
        //public Fraction()
        //{
        //    integer = 0;
        //    numerator = 0;
        //    denominator = 0;
        //}
        //public Fraction(int integer)
        //{
        //    this.integer = integer;
        //    numerator = 0;
        //    denominator = 0;
        //}
        //public Fraction(int numerator, int denominator)
        //{
        //    integer = 0;
        //    this.numerator = numerator;
        //    this.denominator = denominator;
        //}
        //public Fraction(int integer, int numerator, int denominator)
        //{
        //    this.integer = integer;
        //    this.numerator = numerator;
        //    this.denominator = denominator;
        //}
        public void Input()
        {
            Console.WriteLine("Set Integer (if there`s no integer set '0'): ");
            INTEGER = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Set Numerator (if there`s no numerator set '0'): ");
            NUMERATOR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Set Denominator (if there`s no denominator set '0'): ");
            DENOMINATOR = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            if (INTEGER == 0) { if (NUMERATOR == 0) Console.WriteLine("Fraction is not specified;");
                else Console.WriteLine($"{NUMERATOR}/{DENOMINATOR}");
            }
            else if (INTEGER!=0) { if (NUMERATOR != 0 && DENOMINATOR != 0) Console.WriteLine($"{INTEGER}({NUMERATOR}/{DENOMINATOR})");
                else Console.WriteLine(INTEGER); }
            else Console.WriteLine("Incorrect input, try again...");
        }
        public void ToImproper()
        {
            if (NUMERATOR!=0 && DENOMINATOR!=0)
            {
                NUMERATOR = NUMERATOR + INTEGER*DENOMINATOR;
                INTEGER = 0; 
            }
        }
        public void ToProper()
        {
                INTEGER = NUMERATOR / DENOMINATOR;
                NUMERATOR = NUMERATOR % DENOMINATOR; 
        }
        static public Fraction operator+(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            fraction1.ToImproper();
            fraction2.ToImproper();
            result.INTEGER = fraction1.INTEGER + fraction2.INTEGER;
            result.NUMERATOR = fraction1.NUMERATOR*fraction2.DENOMINATOR  + fraction2.NUMERATOR*fraction1.DENOMINATOR;
            result.DENOMINATOR = fraction1.DENOMINATOR * fraction2.DENOMINATOR;
            result.ToProper();
            return result;
        }
        static public Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            fraction1.ToImproper();
            fraction2.ToImproper();
            result.INTEGER = fraction1.INTEGER - fraction2.INTEGER;
            result.NUMERATOR = fraction1.NUMERATOR * fraction2.DENOMINATOR - fraction2.NUMERATOR * fraction1.DENOMINATOR;
            result.DENOMINATOR = fraction1.DENOMINATOR * fraction2.DENOMINATOR;
            result.ToProper();
            return result;
        }
        static public Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            fraction1.ToImproper();
            fraction2.ToImproper();
            result.INTEGER = fraction1.INTEGER * fraction2.INTEGER;
            result.NUMERATOR = fraction1.NUMERATOR * fraction2.NUMERATOR;
            result.DENOMINATOR = fraction1.DENOMINATOR * fraction2.DENOMINATOR;
            result.ToProper();
            return result;
        }
        static public Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            fraction1.ToImproper();
            fraction2.ToImproper();
            if (fraction1.INTEGER!=0 && fraction2.INTEGER!=0)
            {
                result.INTEGER = fraction1.INTEGER / fraction2.INTEGER; 
            }
            else result.INTEGER = 0;
            result.NUMERATOR = fraction1.NUMERATOR * fraction2.DENOMINATOR;
            result.DENOMINATOR = fraction1.DENOMINATOR * fraction2.NUMERATOR;
            result.ToProper();
            return result;
        }
    }
}
