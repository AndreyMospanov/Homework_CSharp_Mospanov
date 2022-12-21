using System;

namespace HW6_T4
{
    internal class President : Worker
    {
        public President(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }        

        public override string Print()
        {
            return "Президе́нт (от лат. praesidens, род. п praesidentis — сидящий впереди, во главе; председатель) — выборный глава государства в государствах с республиканской или смешанной формой правления, избираемый на установленный (например, конституцией) срок с ограниченной законом властью.";
        }
    }
}
