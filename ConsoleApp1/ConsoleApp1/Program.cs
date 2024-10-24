using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] arr=new string[5];
            arr[0] = "Aya";
            arr[1] = "Atef";
            arr[2] = "Mostafa";
            arr[3] = "Elagamy";
            arr[4] = " Osama";

            var s = arr[2..^2];
            s.print();
            //Console.WriteLine(arr[5]);
            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static void print<T>(this T[] source)
        {
             if ( source == null)
            //if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }
            Console.Write("{ ");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write($"{source[i]}");
                Console.Write(i < source.Length - 1 ? ", " : "");
            }
            Console.WriteLine(" }");
        }
    }
}
    

