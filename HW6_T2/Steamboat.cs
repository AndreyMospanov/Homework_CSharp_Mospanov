using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    internal class Steamboat : Device
    {
        public Steamboat(string name, double power) : base(name, power) { }

        public override void Sound()
        {
            Console.WriteLine("boooooooooooo!!!");
        }

        public override string Desc()
        {
            return "Парохо́д — судно, оснащённое поршневой паровой машиной или паровой турбиной в качестве тягового двигателя. Пароход, движимый паровой турбиной, называют турбоходом, или, точнее, паротурбоходом — в отличие от газотурбохода — судна, оснащённого газовой турбиной и являющегося разновидностью теплохода.";
        }

    }
}
