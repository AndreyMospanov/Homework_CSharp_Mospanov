/*Задание 1
Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив 
А числами, введенными с клавиатуры пользователем, а 
двумерный массив В случайными числами с помощью 
циклов. Вывести на экран значения массивов: массива 
А в одну строку, массива В — в виде матрицы. Найти в 
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее 
произведение всех элементов, сумму четных элементов 
массива А, сумму нечетных столбцов массива В.*/
namespace HW2_T1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double[] A = new double[5];
            double[,] B = new double [3,4];
            double max, min, sum, multiplex, evenSumA, oddColSumB;
            Console.WriteLine("Заполните одномерный массив из пяти элементов");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"эл. {i + 1}: ");
                double.TryParse(Console.ReadLine(), out A[i]);
            }
            Console.WriteLine("Массив А:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{A[i]} ");
            }

            Console.WriteLine("\nМассив В:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Random rnd = new Random();
                    B[i,j] = rnd.NextDouble() * 100;
                    B[i, j] = Math.Round(B[i, j], 2);
                    Console.Write($"{B[i,j]} ");
                }
                Console.WriteLine();
            }

            max = A[0];
            min = A[0];
            sum = 0;
            multiplex = 1;
            evenSumA = 0;
            oddColSumB = 0;

            for (int i = 0; i < 5; i++)
            {
                max = max > A[i] ? max : A[i];
                min = min < A[i] ? min : A[i];
                sum += A[i];
                multiplex *= A[i];
                if((i+1) % 2 == 0)
                    evenSumA += A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    max = max > B[i,j] ? max : B[i, j];
                    min = min < B[i, j] ? min : B[i, j];
                    sum += B[i, j];
                    multiplex *= B[i, j];
                    if ((j + 1) % 2 == 1)
                        oddColSumB += B[i, j];
                }
            }
            Console.WriteLine($"Сумма всех элементов = {sum}\nМинимальный элемент = {min}\nМаксимальный элемент = {max}\nПроизведение всех членов массивов = {multiplex}\nСумма четных элементов массива А = {evenSumA}\nСумма нечетных столбцов массива В = {oddColSumB}");
        }
    }
}