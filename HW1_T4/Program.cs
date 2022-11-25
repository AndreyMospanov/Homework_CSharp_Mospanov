/*Задание 4
Пользователь вводит шестизначное число. После чего 
пользователь вводит номера разрядов для обмена цифр. 
Например, если пользователь ввёл один и шесть — это 
значит, что надо обменять местами первую и шестую 
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке*/
namespace HW1_T4
{
    
    internal class Program
    {
        static int GetInt(int left, int right)
        {
            try
            {                
                int.TryParse(Console.ReadLine(), out int num);
                if (num < left || num > right)
                {
                    throw new Exception("Число за пределами допустимых значений");
                }
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
                Console.WriteLine("Попробуйте снова");
            }
            
             return GetInt(left, right);   
        }

        static int Converter(int num, int left, int right)
        {
            int temp, power;
            int[] arr = new int[6];
            double tempD = 0;
            for (int i = 5; i >= 0; i--)
            {
                arr[i] = num % 10;
                num /= 10;
            }
            temp = arr[right];
            arr[right] = arr[left];
            arr[left] = temp;
            for (int i = 0; i < 6; i++)
            {
                power = 5 - i;
                tempD += arr[i] * Math.Pow(10, power); 
            }
            temp = (int)tempD;
            return temp;
        }

        static void Main(string[] args)
        {
            int num, left, right;
            Console.WriteLine("Введите шестизначное число ");
            num = GetInt(100000, 999999);
            Console.WriteLine("Введите порядковые номера чисел, которые нужно поменять"); ;
            left = GetInt(1, 6);
            right = GetInt(1, 6);
            Console.WriteLine($"Результат: {Converter(num, --left, --right)}");
        }
    }
}