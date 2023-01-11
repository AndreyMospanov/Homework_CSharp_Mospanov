/*Задание 2
Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если 
пользователь ввёл five, приложение должно вывести на 
экран 5.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [0] = "null",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine"
            };
            Console.WriteLine("Введите значение");
            int.TryParse(Console.ReadLine(), out int index);
            Console.WriteLine(dic[index]);
        }
    }
}
