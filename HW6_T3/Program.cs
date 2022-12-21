
using System;

namespace HW6_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Violin stradyvari = new Violin("Stradivari");
            Ukulele uk = new Ukulele("Hawaiian");
            Console.WriteLine(stradyvari.Desc());
            Console.WriteLine();
            Console.WriteLine(uk.Desc());
        }
    }
}
