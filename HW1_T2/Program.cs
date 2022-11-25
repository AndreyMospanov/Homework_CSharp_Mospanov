/*Задание 2
Пользователь вводит с клавиатуры два числа. Первое 
число — это значение, второе число процент, который 
необходимо посчитать. Например, мы ввели с клавиатуры 
90 и 10. Требуется вывести на экран 10 процентов от 90. 
Результат: 9*/
namespace HW1_T2
{
    internal class Program
    {
        static float CalculatePercent(float num, float percent)
        {
            return num*(percent/100);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            float.TryParse(Console.ReadLine(), out float num);
            Console.WriteLine("Введите процент");
            float.TryParse(Console.ReadLine(), out float percent);
            Console.WriteLine($"{percent} процентов от {num} = {CalculatePercent(num, percent)}");
        }
    }
}