using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 1.7; 
            double weight = 45; 
            double bmi;
            bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi + "です。");


        }
    }
}
