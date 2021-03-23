using System;


namespace PrimeNumber
{
    class Program
    {
        public class PrintNumber
        {
            public static void PrimeNumber()
            {
                for (var i = 2; i < 100; i++)
                {
                    bool isPrimeNumber = true;
                    for (var j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if (isPrimeNumber)
                    {
                        Console.Write(i + "-");
                    }
                }
            }
        }
       
        static void Main(string[] args)
        {
            PrintNumber.PrimeNumber();
            Console.ReadLine();
        }
    }
}
