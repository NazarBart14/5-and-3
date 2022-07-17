using System;
using System.Text;
using static System.Console;

namespace другий_запуск
{
    internal class Program
    {

        static void Main()
        {
            OutputEncoding = Encoding.Unicode;
            Write("Write nomber from 1 to 100 - ");
            int num = Convert.ToInt32(ReadLine());
            Console.WriteLine(num);


                if  (num % 5 == 0 && num % 3 == 0)
                {
                Console.WriteLine("Fizz Buzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (num % 3 == 0)
                {
                    
                Console.WriteLine("Fizz");

                }
                else if(num % 5 != 0 && num % 3 != 0)
                {
                    Console.WriteLine("Помилка");
                }
            
        }
    }
}
