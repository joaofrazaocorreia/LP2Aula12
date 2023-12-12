using System;

namespace LazySingleFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintValue();
            SetValue(2.0f);
            PrintValue();
            SetValue(4.0f);
            PrintValue();
            SetValue(6.0f);
            PrintValue();
            SetValue(8.0f);
            PrintValue();
            SetValue(69.42f);
            PrintValue();
        }

        private static void SetValue(float value)
        {
            Singleton.Value = value;
        }

        private static void PrintValue()
        {
            Console.WriteLine(Singleton.Value);
        }
    }
}
