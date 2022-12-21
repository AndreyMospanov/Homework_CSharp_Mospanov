/*Задание 2
Напишите метод, который проверяет является ли 
переданное число «палиндромом». Число передаётся в 
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как 
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.*/
namespace HW3_T2
{
    internal class Program
    {
        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Введите слово");
            input = Console.ReadLine();
            if (IsPalindrome(input))
                Console.WriteLine("Это палиндром");
            else
                Console.WriteLine("Это не палиндром");
        }
    }
}