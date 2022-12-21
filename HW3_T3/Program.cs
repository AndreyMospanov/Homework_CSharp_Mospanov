/*Задание 3
Напишите метод, фильтрующий массив на основании 
переданных параметров. Метод принимает параметры: 
оригинальный_массив, массив_с_данными_для_фильтрации.
Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 -1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 -1 — результат работы метода*/
namespace HW3_T3
{
    internal class Program
    {
        static char[] Filtrator(ref char[] orig, ref char[] filter)
        {
            List<char> result = new List<char>();
            result = orig.ToList();
            for (int i = orig.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < filter.Length; j++)
                {
                    if (orig[i] == filter[j])
                        result.RemoveAt(i);
                    
                }
            }
            return result.ToArray(); 
        }


        static void Main(string[] args)
        {
            int length, filterLength;
            char[] orig, filter;
            Console.WriteLine("Введите размер исходного массива");
            int.TryParse(Console.ReadLine(), out length);
            orig = new char[length]; 
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите член массива {i + 1}");
                orig[i] = Console.ReadLine().ToCharArray()[0];
            }
            Console.WriteLine("Введите размер массива-фильтра");
            int.TryParse(Console.ReadLine(), out filterLength);
            filter = new char[length];
            for (int i = 0; i < filterLength; i++)
            {
                Console.WriteLine($"Введите член массива {i + 1}");
                filter[i] = Console.ReadLine().ToCharArray()[0];
            }
            Console.WriteLine("Результат фильтрации:");
            orig = Filtrator(ref orig, ref filter);
            for (int i = 0; i < orig.Length; i++)
            {
                Console.Write($"{orig[i]} ");
            }
        }
    }
}