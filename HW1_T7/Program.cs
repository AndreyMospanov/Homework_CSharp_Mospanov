/*Задание 7
Пользователь вводит с клавиатуры два числа. Нужно 
показать все четные числа в указанном диапазоне. Если 
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
ввел 20 и 11, требуется нормализация, после которой 
начало диапазона станет равно 11, а конец 20*/
namespace HW1_T7
{
    internal class Program
    {
        static void Swap(ref int left, ref int right)
        {
            int temp;
            temp = left;
            left = right;
            right = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон чисел для получения чётных между ними");
            int.TryParse(Console.ReadLine(), out int left);
            int.TryParse(Console.ReadLine(), out int right);
            if(left > right)
                Swap(ref left, ref right);
            for (int i = left; i <= right; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
        }
    }
}