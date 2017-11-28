using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumber = new Random();
            int getal = RandomNumber.Next(1, 50);
            string invoer ="";
            int invoerGetal = 0;

            Console.WriteLine("Gok het getal, het zit tussen 1 en 50!");
            while (invoerGetal != getal)
            {
                invoer = Console.ReadLine();
                invoerGetal = Convert.ToInt32(invoer);
                if (invoerGetal < getal)
                {
                    Console.WriteLine("Hoger!");
                } 
                else if (invoerGetal > getal)
                {
                    Console.WriteLine("Lager!");
                }
                else if (invoerGetal == getal)
                {
                    Console.WriteLine("Goed geraden! {0} was het getal!", getal);
                }
            }
        }
    }
}
