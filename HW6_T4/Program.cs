/*Задание 4
Создать абстрактный базовый класс Worker (работника) 
с методом Print(). Создайте четыре производных класса: 
President, Security, Manager, Engineer. Переопределите метод
Print() для вывода информации, соответствующей каждому типу работника.*/
using System;

namespace HW6_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mngr = new Manager("Манагер");
            President prst = new President("Mr.President");
            Console.WriteLine(mngr.Print());
            Console.WriteLine(prst.Print());

        }
    }
}
