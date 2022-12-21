/*Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса.*/
namespace HW3_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite myPage = new WebSite(new byte[4] {192, 168, 1, 1}, "My Blog", "https://www.mypage.com".ToString(), "this is my page that does not exist");
            myPage.Edit();
            Console.WriteLine(myPage.ToString()); 
        }
    }
}