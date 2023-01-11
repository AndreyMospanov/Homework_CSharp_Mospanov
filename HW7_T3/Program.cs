/*Задание 3
Создайте класс «Заграничный паспорт». Вам необходимо 
хранить информацию о номере паспорта, ФИО владельца, 
дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации 
неверное, генерируйте исключение.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForeignPassport fp = new ForeignPassport("123", "456", "0", "asdfg", "=-0", "01.01.23", "dep");
        }
    }
}
