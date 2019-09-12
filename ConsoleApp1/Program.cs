using System;

namespace Calculate
{
    public class Calculator
    {
        public static void Sum(int a, int b) => Write.WriteNum(a + b);

        public static void Del(int a, int b) => Write.WriteNum(a - b);
        
        public static void Mult(int a, int b) => Write.WriteNum(a * b);

        public static void Div(int a, double b) => Write.WriteNum(a / b);
    }

    public class Write
    {
        public static void WriteNum(double c) => Console.WriteLine(Convert.ToString(c));
    }

    class Program
    {
        static void Main(string[] args)
        {
            //К примеру
            Calculator.Div(5,2);
            Console.ReadKey();
        }
    }
}