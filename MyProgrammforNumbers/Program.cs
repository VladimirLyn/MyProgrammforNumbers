using System;

namespace MyProgrammforNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.WriteLine("В какой системе число? \n 1) Двоичная 2) Восьмеричная 3) Десятичная 4) Шестнадцатеричная");
                string StypeOfNumber = Console.ReadLine();
                int i = Convert.ToInt32(StypeOfNumber);

                if (i != 1 && i != 2 && i != 3 && i != 4)
                {
                    Console.WriteLine("Не понятно что за фигня");
                }

                Console.WriteLine("Введите число");
                string Snumber = Console.ReadLine();
                
                if (i == 1)
                {
                    int Inumber = Convert.ToInt32(Snumber, 2);
                    Console.WriteLine(Convert.ToString(Inumber, 8));
                    Console.WriteLine(Convert.ToString(Inumber, 10));
                    Console.WriteLine(Convert.ToString(Inumber, 16));
                }

                if (i == 2)
                {
                    int Inumber = Convert.ToInt32(Snumber, 8);
                    Console.WriteLine(Convert.ToString(Inumber, 2));
                    Console.WriteLine(Convert.ToString(Inumber, 10));
                    Console.WriteLine(Convert.ToString(Inumber, 16));
                }

                if (i == 3)
                {
                    int Inumber = Convert.ToInt32(Snumber, 10);
                    Console.WriteLine(Convert.ToString(Inumber, 2));
                    Console.WriteLine(Convert.ToString(Inumber, 8));
                    Console.WriteLine(Convert.ToString(Inumber, 16));
                }

                if (i == 4)
                {
                    int Inumber = Convert.ToInt32(Snumber, 16);
                    Console.WriteLine(Convert.ToString(Inumber, 2));
                    Console.WriteLine(Convert.ToString(Inumber, 8));
                    Console.WriteLine(Convert.ToString(Inumber, 10));
                }
            }
        }
    }
}
