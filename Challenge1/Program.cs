using System;
using System.Collections.Generic;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo1();
            // Demo2();

        }

        private static void Demo2()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.SumFibonacci(20);
        }

        private static void Demo1()
        {
            //girilen sayının 3 yada 5 in katlarının toplamı
            Multiples multiples = new Multiples();
            multiples.SumOfTheMultiples(15);
        }
    }
    class Multiples
    {
        public void SumOfTheMultiples(int number)
        {
            int result = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum of all the multiples 3 or 5: " + result);
        }
    }
    class Fibonacci
    {
        public void SumFibonacci(int number)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int previousNumber;
            int resultSum = 0;
            if (number < 40)
            {
                for (int i = 2; i < number; i++)
                {
                    previousNumber = secondNumber + firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = previousNumber;
                    if (previousNumber % 2 == 0)
                    {
                        resultSum += previousNumber;
                    }
                }
                Console.WriteLine("toplamı: " + (resultSum + 2));
            }
            else
            {
                Console.WriteLine("Daha küçük sayı giriniz");
            }
        }
    }

}
