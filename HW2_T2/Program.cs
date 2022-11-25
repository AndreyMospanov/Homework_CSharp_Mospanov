/*Задание 2
Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
Определить сумму элементов массива, расположенных 
между минимальным и максимальным элементами*/
namespace HW2_T2
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
            int[,] arr = new int[5, 5];
            int min, max;
            int minI = 0;
            int minJ = 0;
            int maxI = 0;
            int maxJ = 0;
            int sum = 0;
            Random rnd = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }

            min = arr[0,0];
            max = arr[0,0];            

            //вычисляем минимумы и максимумы и их индексы в массиве
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i,j] < min)
                    {
                        minI = i;
                        minJ = j;
                        min = arr[i,j];
                    }

                    if (arr[i,j] > max)
                    {
                        maxI = i;
                        maxJ = j;
                        max = arr[i,j];
                    }
                }
            }            

            //для того, чтобы при суммировании идти от более раннего элемента к более позднему
            if(minI == maxI && minJ >= maxJ || minI > maxI)
            {
                Swap(ref minI, ref maxI);
                Swap(ref minJ, ref maxJ);
            }
            
            //вычисляем сумму элементов между мин и макс
            for (int i = 0; i < 5; i++)
            {
                if(i == minI)
                {
                    for (int j = minJ; j < 5; j++)
                    {
                        sum += arr[i,j];                        
                    }
                }
                else if(i > minI && i < maxI)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        sum += arr[i, j];                        
                    }
                }
                else if(i == maxI)
                {
                    for (int j = 0; j <= maxJ; j++)
                    {
                        sum += arr[i, j];                        
                    }
                }               
            }

            sum = sum - min - max;
            Console.WriteLine($"Результат = {sum}"); 
        }
    }
}