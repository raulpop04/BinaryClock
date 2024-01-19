using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    class Program
    {
        static void Main()
        {

            Console.Write("Introduceti ora curenta (HH:mm:ss): ");
            string input = Console.ReadLine();


            if (DateTime.TryParseExact(input, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime oraCurenta))
            {

                AfiseazaCeasBinar(oraCurenta);
            }
            else
            {
                Console.WriteLine("Formatul orei introdus nu este valid.");
            }
        }

        static void AfiseazaCeasBinar(DateTime ora)
        {

            int ore = ora.Hour;
            int minute = ora.Minute;
            int secunde = ora.Second;

            string binarOre = Convert.ToString(ore, 2).PadLeft(5, '0');
            string binarMinute = Convert.ToString(minute, 2).PadLeft(6, '0');
            string binarSecunde = Convert.ToString(secunde, 2).PadLeft(6, '0');


            Console.WriteLine($"Ceas binar: {binarOre}:{binarMinute}:{binarSecunde}");
        }
    }
}
