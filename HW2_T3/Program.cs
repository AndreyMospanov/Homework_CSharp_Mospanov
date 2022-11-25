/*Задание 3
Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.*/
namespace HW2_T3
{
    internal class Program
    {
        static string Cipher(ref string word, int shift)
        {
            string result = string.Empty;
            int[] num = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                num[i] = (int)word[i] - shift;
                result += (char)num[i];
            }            

            return result;
        }

        static string Decipher(string word, int shift)
        {
            string result = string.Empty;
            int[] num = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                num[i] = (int)word[i] + shift;
                result += (char)num[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string word = string.Empty;
            Console.WriteLine("Запишите слово");
            word = Console.ReadLine();
            word = Cipher(ref word, 3);
            Console.WriteLine($"зашифрованное слово {word}");
            word = Decipher(word, 3);
            Console.WriteLine($"расшифрованное слово {word}");
        }
    }
}