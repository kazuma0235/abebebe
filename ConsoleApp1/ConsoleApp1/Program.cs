using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = GetInputAndParsedFloat("身長を入力してください");
            float weight = GetInputAndParsedFloat("体重を入力してください");
            float bmi = CalcBMI(weight, height);
            bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi + "です。");


        }
        static float GetInputParseFloat(string log)
        {
            bool parseSuccess = false;
            float parsedValue = 0f;
            while(!parseSuccess)
            {
                Console.WriteLine(log);
                string Input = Console.ReadLine();
                parseSuccess = float.TryParse(Input, out parsedValue);
            }
        }
    }
}
