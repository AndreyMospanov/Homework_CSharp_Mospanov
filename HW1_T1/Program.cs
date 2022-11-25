/*Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке*/
namespace Task1;
class Program
{
   static void Logic(int num)
    {
        if (num % 3 == 0 && num % 5 != 0)
            Console.WriteLine("Fizz");
        else if (num % 5 == 0 && num % 3 != 0)
            Console.WriteLine("Buzz");
        else if (num % 5 == 0 && num % 3 == 0)
            Console.WriteLine("Fizz Buzz");
        else
            Console.WriteLine(num);
    }
    static void Main(string[] args)
    {        
        try
        {
            Console.WriteLine("Введите число от 1 до 100");
            int.TryParse(Console.ReadLine(), out int num);
            if (num < 1 || num > 100)
                throw new Exception("Число должно быть от 1 до 100");
            else
                Logic(num);
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Возникло исключение: {ex.Message}");
        }
    }
}