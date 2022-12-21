/*Задание 5
Создайте класс «Журнал». Необходимо хранить в 
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса*/
namespace HW3_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal(1990);
            Console.WriteLine(myJournal.ToString()); 
            myJournal.Edit();
            Console.WriteLine(myJournal.ToString());
        }
    }
}