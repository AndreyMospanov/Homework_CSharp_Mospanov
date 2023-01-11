/*Задание 4
Пользователь вводит в строку с клавиатуры логическое 
выражение. Например, 3>2 или 7<3. Программа должна 
посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа 
и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок 
ввода используйте механизм исключений.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_T4
{
    
    internal class Program
    {
       public static bool LogicalEx(int num1, string logic, int num2)
        {
            try
            {
                switch (logic)
                {
                    case ">":
                        {
                            return num1 > num2;
                        }
                    case ">=":
                        {
                            return num1 >= num2;
                        }
                    case "<":
                        {
                            return num1 < num2;
                        }
                    case "<=":
                        {
                            return num1 <= num2;
                        }
                    case "==":
                        {
                            return num1 == num2;
                        }
                    case "!=":
                        {
                            return num1 != num2;
                        }
                    default:
                        {
                            throw new Exception("Неверное логическое выражение");
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

       public static string[] Data(string input)
        {
            string[] nums = new string[2];            
            string logic = String.Empty;
            int index = 0;
            input.Trim(' ');

            for (int i = 0; i < input.Length; i++)
            {
                if((int)input[i] > 47 && (int)input[i] < 58)
                {
                    nums[index] += input[i];
                }
                else
                {
                    index = 1;
                    logic += input[i];
                }
            }     
            
            return new string[] { nums[0], logic, nums[1] };
        }
        static void Main(string[] args)
        {
            string input;
            string[] data;
            Console.WriteLine("Введите выражение");
            input = Console.ReadLine();
            data = input.Split(' ');
            //отформатируем выражение, если оно написано слитно
            if (data.Length != 3)
            {
                data = Data(input);
            }

            try
            {
                Console.WriteLine(LogicalEx(int.Parse(data[0]), data[1], int.Parse(data[2])));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
