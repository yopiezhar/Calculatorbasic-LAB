using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b));

            Console.WriteLine("\nTekan sembarangan key untuk keluar");
            Console.ReadKey();
 }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;

        }
    }
   
}
