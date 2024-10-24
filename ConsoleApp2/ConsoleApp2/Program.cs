using System;
namespace ConsoleAPP2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            

            object x = "aya";
            switch (x)
            {
                case int i: Console.WriteLine($"its int : sqr of {i} = {i*i}");
                    break;
                case string i:
                    Console.WriteLine($"its string : captalize of {i} = {i.ToUpper()}");
                    break;
            }
            
        }
    }
}