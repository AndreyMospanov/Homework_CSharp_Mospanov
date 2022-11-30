/*Задание 4
Создайте приложение, которое производит операции 
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц*/

namespace HW2_T4
{
    internal class Program
    {
        static int[,] NumMultiply(int[,] arr, int x, int y, int num)
        {
            int[,] arrResult = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arrResult[i,j] = arr[i,j] * num;
                }                
            }
            return arrResult;
        }

        static int[,] MatrixMultiply(int[,] arr1, int[,] arr2, int x, int y)
        {
            int[,] arrResult= new int[x,y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arrResult[i,j] = arr1[i, j] * arr2[i,j];
                }
            }
            return arrResult;
        }

        static int[,] MatrixSum(int[,] arr1, int[,] arr2, int x, int y)
        {
            int[,] arrResult = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arrResult[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arrResult;
        }

        static void PrintMatrix(ref int[,] arr, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
        }

        static void CreateMatrix(ref int[,] arr, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                }
            }
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int[,] arr1 = new int[x, y];
            int[,] arr2 = new int[x, y];
            CreateMatrix(ref arr1, x, y);
            CreateMatrix(ref arr2, x, y);
            PrintMatrix(ref arr1, x, y);
            PrintMatrix(ref arr2, x, y);
            Console.WriteLine("Умножим первый массив на 2");
            arr1 = NumMultiply(arr1, x, y, 2);
            PrintMatrix(ref arr1, x, y);
            Console.WriteLine("Сложим первый и второй массив");
            arr2 = MatrixSum(arr1, arr2, x, y);
            PrintMatrix(ref arr2, x, y);
            Console.WriteLine("Перемножим массивы");
            arr1 = MatrixMultiply(arr1, arr2, x, y);
            PrintMatrix(ref arr1, x, y);


        }
    }
}