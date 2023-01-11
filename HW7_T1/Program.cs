/*Модуль 3. Часть 2
Задание 1
Создайте приложение калькулятор для перевода числа 
из одной системы исчисления в другую. Пользователь с помощью меню выбирает направление перевода. Например, 
из десятичной в двоичную. После выбора направления, 
пользователь вводит число в исходной системе исчисления. 
Приложение должно перевести число в требуемую систему. Предусмотреть случай выхода за границы диапазона, 
определяемого типом int, неправильный ввод*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_T1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
