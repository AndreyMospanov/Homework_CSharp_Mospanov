using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    internal class Teapot:Device
    {
        public Teapot(string name, double power) : base(name, power) { }

        public override void Sound()
        {
            Console.WriteLine("щщщщщщщщщщщщщщ!");
        }

        public override string Desc()
        {
            return $"Ча́йник — полое изделие (сосуд) различной формы с крышкой, ручкой и носиком (также существуют чайники без носика), предназначенное для кипячения воды и заваривания чая.";
        }
    }
}
