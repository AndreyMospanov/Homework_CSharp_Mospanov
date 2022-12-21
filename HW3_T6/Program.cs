/*Задание 6
Создайте класс «Магазин». Необходимо хранить в 
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.*/
namespace HW3_T6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            myShop.Edit();
            Console.WriteLine(myShop.ToString());
        }
    }
}