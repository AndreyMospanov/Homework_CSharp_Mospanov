/*Задание 3
Пользователь вводит с клавиатуры четыре цифры. 
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
сформировать число 1578*/
namespace HW1_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Введите 4 числа");
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);
            int.TryParse(Console.ReadLine(), out int num4);
            result = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            Console.WriteLine($"Результат {result}");
        }
    }
}