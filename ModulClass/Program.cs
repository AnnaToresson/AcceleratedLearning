using System;
using System.Collections.Generic;

namespace ModulClass
{
    public class PointList
    {
        private readonly List<Point> _pointList;

        public PointList()
        {
            _pointList = new List<Point>();
        }

        public void Add(Point point)
        {
            _pointList.Add(point);
        }

        public void Print()
        {
            foreach (var point in _pointList)
            {
                Console.WriteLine(point.ToString());
            }
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {

            Run();
        }


        public static void Run()
        {

            {
                var pointList = new PointList();
                string fruit = "Apple";
                int age = 50;
                var date = DateTime.Now;

                Point_Struct point = new Point_Struct(3, 4);

                pointList.Add(new Point(10, 20));
                pointList.Add(new Point(10, 15));
                pointList.Add(new Point(10, 12));


                Console.Write("Before" + "\t\t\t" + $"fruit ={fruit}");
                ChangeFruit(out fruit);

                Console.WriteLine();
                Console.Write("After" + "\t\t\t" + $"fruit ={ fruit}\n");
                Console.WriteLine();

                Console.Write("Before" + "\t\t\t" + $"age ={ age}");
                ChangeAge(out age);
                Console.WriteLine();
                Console.Write("After" + "\t\t\t" + $"age ={ age}\n");
                Console.WriteLine();

                Console.Write("Before" + "\t\t\t" + $"date ={ date}");
                date = ChangeDate();
                Console.WriteLine();
                Console.Write("After" + "\t\t\t" + $"date ={ date}\n");
                Console.WriteLine();

                Console.Write("Before" + "\t\t\t" + $"point ={ point}");
                ChangePoint(point);
                Console.WriteLine();
                Console.Write("After" + "\t\t\t" + $"point ={ point}\n");
                Console.WriteLine();

                pointList.Print();
            }

            Console.WriteLine();
        }

        public struct Point_Struct
        {
            public Point_Struct(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return $"({X},{Y})";
            }

        }


        private static void ChangeFruit(out string fruit)
        {
            fruit = "apple";
        }

        private static void ChangeAge(out int age)
        {
            age = 75;

        }

        private static DateTime ChangeDate()
        {

            return DateTime.Now.AddDays(1);
        }
        private static void ChangePoint(Point_Struct point)
        {
            point.X = 72;
            point.Y = 50;
        }


    }

    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
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
