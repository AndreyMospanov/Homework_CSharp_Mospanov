/*Задание 6
Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий 
или наоборот.*/
namespace HW1_T6
{
    internal class Program
    {
        static float Converter(int choice, float value)
        {
            float k;
            if(choice == 1)
            {
                k = 9.0f / 5.0f;                
                return k * value + 32;
            }
            else
            {
                k = 5.0f / 9.0f;                
                return k * (value - 32);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Цельсий в Фаренгейт\n2. Фаренгейт в Цельсий");
            int.TryParse(Console.ReadLine(), out int choice);
            Console.WriteLine("Введите значение");
            float.TryParse(Console.ReadLine(), out float value);
            Console.WriteLine($"Результат: {Converter(choice, value)}");
        }
    }
}