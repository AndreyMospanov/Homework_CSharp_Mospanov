/*Задание 6
Создайте класс «Магазин». Необходимо хранить в 
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.*/
using System;

namespace HW3_T6
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Profile { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public double Square { get; set; }

        public Shop(string name, string profile, string description, string phone, string mail, double square = 0)
        {
            Name = name;
            Profile = profile;
            Description = description;
            Phone = phone;
            Mail = mail;
        }

        public Shop() : this(" ", " ", " ", " ", " ") { }

        public void Edit()
        {
            Console.WriteLine("Введите название");
            Name = Console.ReadLine();
            Console.WriteLine("Введите профиль магазина");
            Profile = Console.ReadLine();
            Console.WriteLine("Введите описание");
            Description = Console.ReadLine();
            Console.WriteLine("Введите телефон");
            Phone = Console.ReadLine();
            Console.WriteLine("Введите почту");
            Mail = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Магазин {Name}\nСпециализация: {Profile}\nОписание: {Description}\nТелефон: {Phone}\nПочта: {Mail}";
        }

        public override bool Equals(object obj)
        {
            return obj is Shop shop &&
                   Square == shop.Square;
        }

        public static bool operator == (Shop s, Shop t)
        {
            return s.Equals(t);
        }

        public static bool operator !=(Shop s, Shop t)
        {
            return !s.Equals(t);
        }

        public static Shop operator + (Shop s, int value)
        {
            return new Shop(s.Name, s.Profile, s.Description, s.Phone, s.Mail, s.Square + value);
        }

        public static Shop operator - (Shop s, int value)
        {
            return new Shop(s.Name, s.Profile, s.Description, s.Phone, s.Mail, s.Square - value);
        }
    }
}
