/*Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_T4
{
    internal class WebSite
    {
        private byte[] ip;
        private string name;
        private string url;
        private string description;

        public WebSite(byte[] ip, string name, string url, string description)
        {
            this.ip = new byte[ip.Length];
            for (int i = 0; i < ip.Length; i++)
            {
                this.ip[i] = ip[i];
            }
            this.name = name;
            this.url = url;
            this.description = description;
        }

        public byte[] IP {get {return this.ip;}}
        public string Name { get; set; }
        public string Url { get { return url;} }
        public string Description { get; set; }

        public void Edit()
        {
            Console.WriteLine("Введите название сайта");
            Name = Console.ReadLine();
            Console.WriteLine("Введите описание");
            Description = Console.ReadLine();
        }

        public override string ToString()        
        {
            return $"website: {Name},\nurl: {Url},\nip: {IP[0]}.{IP[1]}.{IP[2]}.{IP[3]},\ndescription: {Description}";
        }
    }
}
