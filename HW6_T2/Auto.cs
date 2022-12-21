using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    internal class Auto : Device
    {
        public Auto(string name, double power) : base(name, power) { }

        public override void Sound()
        {
            Console.WriteLine("wroom!");
        }

        public override string Desc()
        {
            return "Автомоби́ль (от др.-греч. αὐτός — сам и лат. mobilis — подвижной, скорый) — моторное безрельсовое дорожное и/или внедорожное, чаще всего автономное, транспортное средство, используемое для перевозки людей и/или грузов, имеющее от четырёх колёс.";
        }

    }
}
