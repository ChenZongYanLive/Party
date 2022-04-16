using System;
using System.Collections.Generic;
using NoUnitTest;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new NumberConverter();
            
            Console.WriteLine("input 1, ans is : " + converter.Replace(1));
            Console.WriteLine("input 2, ans is : " + converter.Replace(2));
            Console.WriteLine("input 3, ans is : " + converter.Replace(3));
            Console.WriteLine("input 6, ans is : " + converter.Replace(6));
            Console.WriteLine("input 5, ans is : " + converter.Replace(5));
            Console.WriteLine("input 10, ans is : " + converter.Replace(10));
            Console.WriteLine("input 15, ans is : " + converter.Replace(15));
            Console.WriteLine("input 30, ans is : " + converter.Replace(30));

            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine();
            
            Console.WriteLine("input 13, ans is : " + converter.Replace(13));
            Console.WriteLine("input 27, ans is : " + converter.Replace(27));
            Console.WriteLine("input 52, ans is : " + converter.Replace(52));
            Console.WriteLine("input 20, ans is : " + converter.Replace(20));
            Console.WriteLine("input 35, ans is : " + converter.Replace(35));
            Console.WriteLine("input 53, ans is : " + converter.Replace(53));
            
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine();
            
            Console.WriteLine("input 7, ans is : " + converter.Replace(7));
            Console.WriteLine("input 14, ans is : " + converter.Replace(14));
            Console.WriteLine("input 17, ans is : " + converter.Replace(17));
            Console.WriteLine("input 21, ans is : " + converter.Replace(21));
            Console.WriteLine("input 35, ans is : " + converter.Replace(35));
            
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine();

            var userConfig = new Dictionary<int, string>
            {
                { 4 , "Gozz" },
                { 6 , "Rozz" },
            };
            
            converter = new NumberConverter(userConfig);
            Console.WriteLine("input 4, ans is : " + converter.Replace(4));
            Console.WriteLine("input 6, ans is : " + converter.Replace(6));
            Console.WriteLine("input 8, ans is : " + converter.Replace(8));
            Console.WriteLine("input 12, ans is : " + converter.Replace(12));
            
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine();
            
            userConfig = new Dictionary<int, string>
            {
                { 3 , "Fizz" },
                { 4 , "Gozz" },
                { 5 , "Buzz" },
                { 6 , "Rozz" },
                { 7 , "Whizz" },
            };
            converter = new NumberConverter(userConfig);
            Console.WriteLine("input 4, ans is : " + converter.Replace(4));
            Console.WriteLine("input 6, ans is : " + converter.Replace(6));
            Console.WriteLine("input 8, ans is : " + converter.Replace(8));
            Console.WriteLine("input 12, ans is : " + converter.Replace(12));
            
            Console.WriteLine("Hello World!");
        }
    }
}