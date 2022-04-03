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
            Console.WriteLine("Zadej číslo bejku. ");
            int cislo1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Zadej číslo kterým bys hodnotil nekoparu. (10)");
            int cislo2 = Convert.ToInt32(Console.ReadLine());
            int[] cisla = { cislo1, cislo2 };
            Console.Clear();
            int max = cisla.Max();
            int min = cisla.Min();
            Console.WriteLine(max + ", " + min);
            Console.ReadLine();
        }
    }
}
