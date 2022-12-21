/*Задание 5
Создайте класс «Журнал». Необходимо хранить в 
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса*/

using System;

namespace HW3_T5
{
    internal class Journal
    {
        private string name;
        private int year;
        private string phone;
        private string mail;
        private string description;
        private int employees;

        public Journal(string name, int year, string phone, string mail, string description, int employees = 0)
        {
            this.name = name;
            this.year = year;
            this.phone = phone;
            this.mail = mail;
            this.description = description;
            if(employees > 0)
            {
                this.Employees = employees;
            }
            else
            {
                this.Employees = 0;
            }
            
        }

        public Journal(int year) : this("noname", year, "none", "none", "no description") { }
        
        public string Name { get { return name; } set { name = value; } }
        public int Year { get { return year; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string Description { get=>description; set { description = value; } }

        public int Employees { get => employees; set { if (value >= 0) employees = value; } }

        public void Edit()
        {
            Console.WriteLine("Измените имя журнала");
            Name = Console.ReadLine();
            Console.WriteLine("Измените телефон");
            Phone = Console.ReadLine();
            Console.WriteLine("Измените почту");
            Mail = Console.ReadLine();
            Console.WriteLine("Измените описание");
            Description = Console.ReadLine();
        }

        public override string ToString()
        {
           return $"Journal {Name} since {Year}.\nContacts: ph.: {Phone}\ne-mail: {Mail}\ndescription: {Description}";
        } 
        
        public static Journal operator + (Journal j, int value)
        {
            return new Journal(j.Name, j.Year, j.Phone, j.Mail, j.Description, j.Employees + value);
        }

        public static Journal operator -(Journal j, int value)
        {
            return new Journal(j.Name, j.Year, j.Phone, j.Mail, j.Description, j.Employees - value);
        }

        public override bool Equals(object obj)
        {
            return (obj as Journal).employees == this.employees;
        }
        public static bool operator == (Journal j, Journal k)
        {
            return j.Equals(k);
        }

        public static bool operator != (Journal j, Journal k)
        {
            return !j.Equals(k);
        }
    }
}
