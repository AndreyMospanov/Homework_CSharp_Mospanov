/*Задание 1
Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле 
для хранения копеек (центы, евроценты, копейки и т.д.).
Реализовать методы для вывода суммы на экран, задания значений для частей. 
На базе класса Money создать класс Product для работы 
с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
Для каждого из классов реализовать необходимые методы и поля.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("product", 100, "р", 0, "коп");
            double x = 4.50;
            Console.WriteLine(product.ToString());
            product += x;
            Console.WriteLine($"{product.ProductName} {x} = {product.ToString()}"); 
        }
    }
}
