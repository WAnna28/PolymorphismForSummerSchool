using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismForSummerSchool
{
    public class CalculateStaticPolymorphism
    {
        public void AddNumbers(int num1, int num2)
        {
            //Console.WriteLine("num1 + num2 = {0}", num1 + num2);
            Console.WriteLine("int, int");
        }

        public void AddNumbers(string num1, int num2)
        {
            Console.WriteLine("string, int");
        }

        public void AddNumbers(short num1, int num2)
        {
            Console.WriteLine("short, int");
        }


        public void AddNumbers(int num1, int num2, int num3)
        {
            Console.WriteLine("num1 + num2 + num3 = {0}", num1 + num2 + num3);
        }
    }

    public class B : CalculateStaticPolymorphism
    {
        public void AddNumbers(double num1, double num2)
        {
            //Console.WriteLine("num1 + num2 = {0}", num1 + num2);
            Console.WriteLine("double, double");
        }
    }
}
