using System;
using System.Text;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {

            //WhatsYourName1();
            //WhatsYourName();
            StringCreation();


        }


        public static void WhatsYourName()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = (Console.ReadLine());
            Console.Write("What is your favorite character? ");
            var character = char.Parse(Console.ReadLine());


            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;



            Console.WriteLine("Your name is: " + name);


            int pension = 65 - Convert.ToInt32(age);
            Console.WriteLine("You have " + pension + " years until retirement");



            if (Char.IsDigit(character))
            {
                Console.WriteLine("Your favorite character is " + character);
            }
            else
                Console.WriteLine("You dont't like numbers");





            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void StringCreation()
        {
            //Console.WriteLine("How many fruits do you want to add?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //var fruits = new list<>;
            //for (int i = 0; i < number; i++)
            //{
            //    var fruit = Console.ReadLine();

            //}

            //foreach (var fruit in fruits)
            //{

            //}
            //Console.WriteLine("You entered three fruits: {fruit}");

            Console.WriteLine();
            Console.Write("Enter fruit 1: ");
            var fruit1 = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            var fruit2 = Console.ReadLine();
            //Försök hitta den här
            Console.Write("Enter fruit 3: ");
            var fruit3 = Console.ReadLine();
            string str = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}!";

            //Console.WriteLine("You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!");
            //Console.WriteLine("You entered three fruits: {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            //Console.WriteLine($"You entered three fruits: {fruit1}, {fruit2}, {fruit3}!");

            Console.WriteLine(str);
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.Append(str);
            Console.WriteLine(stringBuilder);

        }

        private static void WhatsYourName1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = Console.ReadLine();
            Console.Write("What is your favorite letter? ");
            var letter = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;




            Console.WriteLine("Your name is: " + name);

            Console.WriteLine("You are " + age + " years old");

            Console.WriteLine("Your favorite letter is " + letter);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }


    }
}
