using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    internal class MicrowaveStation : Device
    {
        public MicrowaveStation(string name, double power) : base(name, power) { }

        public override void Sound()
        {
            Console.WriteLine("piu!");
        }

        public override string Desc()
        {
            return "Микроволно́вая печь, СВЧ-печь — электроприбор, позволяющий совершать разогрев водосодержащих веществ благодаря электромагнитному излучению дециметрового диапазона (обычно с частотой 2450 МГц) и предназначенный для быстрого приготовления, подогрева или размораживания пищи.";
        }

    }
}
