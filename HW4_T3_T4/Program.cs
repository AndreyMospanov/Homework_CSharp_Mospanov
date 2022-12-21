/*Задание 3
Создайте приложение для перевода обычного текста 
в азбуку Морзе. Пользователь вводит текст. Приложение 
отображает введенный текст азбукой Морзе. Используйте 
механизмы пространств имён.
Задание 4
Добавьте к предыдущему заданию механизм перевода 
текста из азбуки Морзе в обычный текст*/
namespace HW4_T3_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Morze.MTranslator translator = new Morze.MTranslator();
            Console.WriteLine("1. С Русского на Морзе\n2. С Морзе на Русский\nВведите число");
            int.TryParse(Console.ReadLine(), out int choice);
            Console.WriteLine("Введите слово");
            word = Console.ReadLine();
            if(word != null)
            {
                if (choice == 1)
                {
                    Console.WriteLine($"Перевод: { translator.Translate(true, word) }"); 
                }
                else
                {
                    Console.WriteLine($"Перевод:  { translator.Translate(false, word) }"); 
                }
            }
            
        }
    }
}