using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EvszakKiszamolo
    {
        public static string Evszak(int honap)
        {
            while (true)
            {
                Console.WriteLine("Adj meg egy szamot 1 és 12 kozott");
                int asd = int.Parse(Console.ReadLine());

                if (asd > 12 || asd < 1)
                {
                    Console.WriteLine("nem jouu");
                }
                else if (asd == 12 || asd == 1 || asd == 2)
                {
                    Console.WriteLine("A honapod tel");
                }
                else if (asd == 3 || asd == 4 || asd == 5)
                {
                    Console.WriteLine("A honapod tavasz");
                }
                else if (asd == 6 || asd == 7 || asd == 8)
                {
                    Console.WriteLine("A honapod nyár");
                }
                else if (asd == 9 || asd == 10 || asd == 11)
                {
                    Console.WriteLine("A honapod ősz");
                }
                else
                {
                    Console.WriteLine("nem jooooooooouu");
                }
                Console.ReadKey();
            }
        }
       
    }
}
