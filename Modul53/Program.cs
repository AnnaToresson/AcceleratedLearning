using System;
using System.Text;

namespace Modul53
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }



        public static void Run()
        {
            {
                Point point = new Point(3, 4);

                Console.Write("Before" + "\t\t" + $"point ={ point}");


                ChangePoint(point);
                Console.WriteLine();
                Console.Write("After" + "\t\t" + $"point ={ point}");
                Console.WriteLine();
            }

            Console.WriteLine();

            {
                StringBuilder stringBuilder = new StringBuilder("Let's go dancing.");
                Console.Write("Before" + "\t\t" + $"sb = {stringBuilder}");
                Console.WriteLine();

                ChangeStringBuilder(stringBuilder);
                Console.Write("After" + "\t\t" + $"sb = {stringBuilder}");
                Console.WriteLine();

            }
            Console.WriteLine();
        }


        private static void ChangePoint(Point point)
        {
            point.X = 12;
            point.Y = 20;
        }

        private static void ChangeStringBuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append(" Yes that would be great!");
        }
    }

    public class Point
    {
        public Point(int x, int y)
        {
            X = y;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
