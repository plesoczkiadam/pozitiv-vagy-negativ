using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozitiv_negativ
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam;
            Console.WriteLine("Kérem a számot");
            Console.Write("szam = ");
            szam = Convert.ToDouble(Console.ReadLine());

            if (szam > 0) 
            {
                Console.WriteLine("{0} szám pózitív", szam);
            }
            else
            {
                if (szam == 0)
                {
                    Console.WriteLine("{0} szám 0", szam);
                }
                else
                {
                    Console.WriteLine("{0} szám negatív", szam);
                }
               
            }
            Console.ReadLine();

        }
    }
}
