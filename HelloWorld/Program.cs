using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "Irek";
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Druga linijka kodu");
            double a = 20;
            double b = 10;
            
            Math math = new Math();
            
            double addResult = math.Add(a, b);
            double substractResult = math.Subtract(a, b);
            
            Console.WriteLine(addResult.ToString());
            Console.WriteLine(substractResult.ToString());

        }
    }
}
