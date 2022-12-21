/*Задание 1
Создайте приложение «Крестики-Нолики». Пользователь играет с компьютером. При старте игры случайным 
образом выбирается, кто ходит первым. Игроки ходят по очереди. Игра может закончиться победой одного из игроков 
или ничьей. Используйте механизмы пространств имён
Задание 2
Добавьте к первому заданию возможность игры с другим пользователем */

using Cross_Zero;

namespace HW4_T1
{
    internal class Program
    {
        static int GetInt(int left, int right)
        {
            int result = 0;
            try
            {
                int.TryParse(Console.ReadLine(), out result);
                if (result < left || result > right)
                {
                    throw new Exception("Число за границами диапазона!");
                }
                else
                    return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Попробуйте снова");
                return GetInt(left, right);                
            }
            
        }
        
        static void Main(string[] args)
        {
            int choice = 0;            
            do
            {
                Cross_Zero.Game game = new Cross_Zero.Game();
                Console.Clear();
                Console.WriteLine("Выберите режим игры:\n1. Человек-Человек\n2. Человек-Компьютер\n0. Выход\n\nНавигация реализована с помощью клавиш: WSAD, поставить свой знак - пробел");
                choice = GetInt(0, 3);
                game.Run(choice);
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
            } while (choice != 0);
            
        }
    }
}