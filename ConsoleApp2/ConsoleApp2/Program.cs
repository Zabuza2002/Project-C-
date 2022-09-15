using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите цифры: ");
            string s = Console.ReadLine();
            foreach (Char ch in s)
            {
                switch (ch)
                {
                    case '0':
                        Console.WriteLine("Ноль");
                        break;
                    case '1':
                        Console.WriteLine("Один");
                        break;
                    case '2':
                        Console.WriteLine("Два");
                        break;
                    case '3':
                        Console.WriteLine("Три");
                        break;
                    case '4':
                        Console.WriteLine("Четыре");
                        break;
                    case '5':
                        Console.WriteLine("Пять");
                        break;
                    case '6':
                        Console.WriteLine("Шесть");
                        break;
                    case '7':
                        Console.WriteLine("Семь");
                        break;
                    case '8':
                        Console.WriteLine("Восемь");
                        break;
                    case '9':
                        Console.WriteLine("Девять");
                        break;
                   
                }
               // Console.Write(ch);
            }
            Console.ReadKey();
        }
        
    }

}
