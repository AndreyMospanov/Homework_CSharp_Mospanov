/*Задание 5
Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday*/
namespace HW1_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season;
            Console.WriteLine("Введите дату. День:");
            int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Введите месяц:");
            int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Введите год:");
            int.TryParse(Console.ReadLine(), out int year);
            DateTime dt = new DateTime(year, month, day);
            if (month < 3 || month == 12)
                season = "Winter";
            else if (month < 6)
                season = "Spring";
            else if (month < 9)
                season = "Summer";
            else
                season = "Autumn";
            Console.WriteLine($"{season} {dt.DayOfWeek}");            
        }
    }
}