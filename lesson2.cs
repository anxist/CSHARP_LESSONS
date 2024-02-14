using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSHARP_LESSONS
{
    class lesson2
    {
        static void Main(string[] args)
        {
            /*ЗАДАНИЕ 1*/

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine("Число кратно и 7, и 23.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Число кратно только 7.");
            }
            else if (number % 23 == 0)
            {
                Console.WriteLine("Число кратно только 23.");
            }
            else
            {
                Console.WriteLine("Число не кратно ни 7, ни 23.");
            }

            Console.ReadLine();

            /*ЗАДАНИЕ 2*/

            Console.Write("Введите x: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Первая координатная четверть");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("Вторая координатная четверть");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Третья координатная четверть");
            }
            else if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine("Четвертая координатная четверть");
            }
            else
            {
                Console.WriteLine("ОШИБКА");
            }

            Console.ReadLine();


            /*ЗАДАНИЕ 3*/

            Console.WriteLine("Ведите двухзначное число");
            int n = int.Parse(Console.ReadLine());
            if (n > 9 && n < 100)
            {
                if (n / 10 > n % 10)
                {
                    Console.WriteLine("Первая цифра больше");
                }
                else if (n / 10 == n % 10)
                {
                    Console.WriteLine("Цыфры одинаковы");
                }

                else if (n / 10 < n % 10)
                {
                    Console.WriteLine("Вторая цифра больше");
                }
                else
                {
                    Console.WriteLine("Число не является двухзначным");
                }
                Console.ReadKey();

            }

            /*ЗАДАНИЕ 4*/
            Console.WriteLine("Напишите трехзначиное число");
            int abc = int.Parse(Console.ReadLine());
            int abc1 = abc / 100;
            int abc2 = (abc / 10) % 10;
            int abc3 = abc % 10;
            Console.WriteLine($"{abc1}, {abc2}, {abc3}");
        }
    }

}
