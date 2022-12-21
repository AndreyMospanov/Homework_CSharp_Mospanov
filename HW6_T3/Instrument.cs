using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T3
{
    internal class Instrument
    {
        public string Show { get; set; }

        public Instrument(string show)
        {
            Show = show;
        }

        public virtual void Sound()
        {
            Console.WriteLine("sound"); ;
        }

        public virtual string Desc()
        {
            return "description";
        }

        public virtual string History()
        {
            return "history";
        }
    }
}
