/*Пользователь с клавиатуры вводит некоторый текст. 
Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.*/
using System.Text;
namespace HW2_T6
{
    internal class Program
    {
        static string Correct(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0].ToString().ToUpper());
            for (int i = 1; i < input.Length; i++)
            {
                sb.Append(input[i]);
                if (input[i] == '.')
                {                    
                    // такая логика нужна на случай, если между точкой и началом следующего предложения несколько пробелов
                    do
                    {
                        i++;
                        if (input[i] != ' ')
                        {
                            sb.Append($" {input[i].ToString().ToUpper()}");
                        }                            
                    } while (input[i] == ' ');                     
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string input = "today is a good day for walking.    i will try to walk near the sea";
            Console.WriteLine(input);
            Console.WriteLine("Исправлено:");
            Console.WriteLine(Correct(input)); 
        }
    }
}