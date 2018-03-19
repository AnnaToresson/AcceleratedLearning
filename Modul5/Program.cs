using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cycles" + "\t\tLength of string" + "\t\tTime");
            StringTest(5);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cycles" + "\t\tLength of string" + "\t\tTime");
            StringTest_Stringbuilder(5);




        }

        private static void StringTest(int cycles)
        {


            //for (int i = 0; i < 500; cycles*10)
            //{

            //}

            while (cycles < 50001)
            {

                var watch = System.Diagnostics.Stopwatch.StartNew();

                string result = GenerateString("Tennis anyone? ", cycles);
                var elapsedTime = watch.ElapsedMilliseconds;
                watch.Stop();

                Console.Write(cycles + "\t\t" + result.Length + "\t\t\t" + elapsedTime + " ms");

                Console.WriteLine();
                cycles = cycles * 10;
            }


        }
        private static void StringTest_Stringbuilder(int cycles)
        {



            while (cycles < 50001)
            {

                var watch = System.Diagnostics.Stopwatch.StartNew();

                string result = GenerateString_Stringbuilder("Tennis anyone? ", cycles);
                var elapsedTime = watch.ElapsedMilliseconds;
                watch.Stop();

                Console.Write(cycles + "\t\t" + result.Length + "\t\t\t" + elapsedTime + " ms");

                Console.WriteLine();
                cycles = cycles * 10;
            }


        }



        private static string GenerateString(string repeatme, int cycles)
        {

            var result = "";


            for (int i = 0; i < cycles; i++)
            {
                result = result + repeatme;

            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return result;

        }

        private static string GenerateString_Stringbuilder(string repeatme, int cycles)
        {

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < cycles; i++)
            {
                result.Append(repeatme);
            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return result.ToString();


        }

       

    }
}
