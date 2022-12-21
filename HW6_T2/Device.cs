using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    public class Device
    {
        public string Name { get; set; }
        public double Power { get; set; }

        public Device(string name, double power)
        {
            Name = name;
            Power = power;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device's sound");
        }

        public override string ToString()
        {
            return $"{Name} {Power}";
        }

        public virtual string Desc()
        {
            return $"Устройство — рукотворный объект (прибор, механизм, конструкция, установка, аппарат, машина) со сложной внутренней структурой, созданный для выполнения определённых функций, обычно в области техники.";
        }
    }
}
