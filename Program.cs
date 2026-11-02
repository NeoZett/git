using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Utflyktsgeneratorn==");

            Console.WriteLine("Hur stor är din budget");
            int budget = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Hur många ska följa med? ");
            int antal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad kostar resan per person?");
            int resan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hur mycket kostar maten");
            int mat = Convert.ToInt32(Console.ReadLine());

            //Räknar ut hur mycket maten och resan kostar för en person.
            int KostnadPerPerson = resan + mat;

            // gruppens totala kostnad
            int TotalKostnad = KostnadPerPerson * antal;
            Console.WriteLine();

            Console.WriteLine("Kostnad per person: " + KostnadPerPerson + " kr");
            Console.WriteLine("Total kostnad: " + TotalKostnad + " kr");

            if (TotalKostnad > budget)
            {
                Console.WriteLine("du har inte tilräkligt med pengar");
            }
            else if (TotalKostnad <= budget )
            {
                Console.WriteLine("du har tillräkligt med pengar");
            }

        }
    }
}