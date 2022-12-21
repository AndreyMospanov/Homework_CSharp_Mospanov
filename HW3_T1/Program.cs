/*Задание 1
Напишите метод, который отображает квадрат из некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ*/
namespace HW3_T1
{
    internal class Program
    {
        static void ShowSquare(int length, char c)
        {
            for (int i = 0; i < length; i++)
            {
                if(i == 0 || i == length - 1)
                {
                    Console.WriteLine(new string(c, length));
                }
                else
                {
                    Console.WriteLine($"{c}{new string(' ', length - 2)}{c}");
                }
            }
            
        }
        static void Main(string[] args)
        {
            char c;
            int length;
            Console.WriteLine("Запишите символ, затем длину стороны");
            c = Console.ReadLine().ToCharArray()[0];
            int.TryParse(Console.ReadLine(), out length);
            ShowSquare(length, c);
        }
    }
}