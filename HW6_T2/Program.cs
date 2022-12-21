/*Задание 2
Создать базовый класс «Устройство» и производные 
классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого 
устройства и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound — издает звук устройства (пишем текстом в 
консоль);
ДОМАШНЕЕ ЗАДАНИЕ
1
■ Show — отображает название устройства;
■ Desc — отображает описание устройства.*/
using System;

namespace HW6_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device("устройство", 0);
            device.Sound();
            Console.WriteLine(device.Desc());
            Console.WriteLine();
            Steamboat paradox = new Steamboat("Paradox", 5000);
            Console.WriteLine(paradox.Desc());
        }
    }
}
