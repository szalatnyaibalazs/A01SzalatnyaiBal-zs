using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01SzalatnyaiBalázs
{
    class Program
    {
        static int[] adat = new int[1000];

        static void Beolvasas()
        {
            StreamReader be = new StreamReader("adatok.dat");
            for (int i = 0; i < adat.Length; i++)
            {
                adat[i] = int.Parse(be.ReadLine())*2;
            }
        }
        static int Maximumertek()
        {
            int max = 0;
            for (int i = 1; i < adat.Length; i++)
            {
                if (adat[i-1] < adat[i])
                {
                    max = adat[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Beolvasas();

            Console.WriteLine("A maximum:{0}",Maximumertek());

            Console.ReadKey();
        }

    }
}
