using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortniteBattlePass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            int cislo1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" ");
            int cislo2 = Convert.ToInt32(Console.ReadLine());
            int[] cisla = { cislo1, cislo2 };
            Console.Clear();
            int max = cisla.Max();
            int min = cisla.Min();
            if (cislo1 == cislo2)
            {
                Console.WriteLine("Cisla se rovnaj");
                Console.ReadLine();
            }
            else if (cislo1 != cislo2)
            {
            Console.WriteLine(max + ", " + min);
            Console.ReadLine();
            }
        }
    }
}
