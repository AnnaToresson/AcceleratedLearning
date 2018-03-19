using System;
using System.Collections.Generic;
using System.Linq;


namespace Modul2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //DoYouNeedToSleep();
            //EnterYourName();
            //ForEnterYourName();
            //RadKolumn();
            //ReverseRadKolumn();
            //ForeachEnterNames();
            EnterNumber();
            //GuessTheNumber();
            //EnterNumber2();
        }

        private static void DoYouNeedToSleep()
        {
            Console.Write("When did you go to bed yesterday? ");
            int sleep = Convert.ToInt32(Console.ReadLine());
            //int sleep=int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int awake = Convert.ToInt32(Console.ReadLine());

            var sleepTime = (24 - sleep) + awake;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            if (sleepTime < 6)
                Console.WriteLine("You've only slept " + sleepTime+" hours. Go back to bed!");

            else if(sleepTime>12)
                Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");


            else
                Console.WriteLine($"You've slept well. ({sleepTime} hours)");

            

            Console.ForegroundColor = ConsoleColor.White;

        }

       
        private static void RepeatNameWithWhile()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int repeat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Decide output separation, comma or line");
            var decide = Console.ReadLine();
            // var decide = Convert.ToInt32(Console.ReadLine());

            while (repeat<10)
            {
                if (decide == "line")
                {
                    int i = 0;

                    while (i < repeat)
                    {
                        Console.WriteLine($"Your name is {name}");//interpolated
                                                                  //Console.WriteLine("Your name is " + name);//concatenation
                                                                  //Console.WriteLine("Your name is {0}", name);//placeholdera
                        i++;
                    }
                    Console.WriteLine();

                }
                else
                {
                    int i = 0;

                    while (i < repeat)
                    {
                        Console.Write($"Your name is {name}, ");//interpolated

                        i++;
                    }
                    Console.WriteLine();
                }
                if(repeat>10)
                    Console.WriteLine("To many times");


                break;

            }
           
        }

        private static void RepeatNameWithFor()
        {
            Console.Write("Enter your name: ");
            var yourName = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int repeatTimes = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            for (int counter = 0; counter < repeatTimes; counter++)
            {
                Console.WriteLine($"Your name is {yourName}");//interpolated
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

        }

        private static void RadKolumn()
        {
            Console.Write("Enter your name: ");
            var yourName = Console.ReadLine();

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbers of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}",yourName +"\t"); 

                }
                Console.WriteLine();
            }
        }

        private static void ReverseRadKolumn()
        {
            Console.Write("Enter your name: ");
            var yourName = Console.ReadLine();
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numbers of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numbers of times to repeat: ");
            int repeat = Convert.ToInt32(Console.ReadLine());


            
            var test = Reverse(yourName);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write("{0,4}{1}", yourName, test);

                }
                Console.WriteLine();
            }



            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {

            //        Console.Write("{0,4}{1}", yourName, test);

            //    }
            //    Console.WriteLine();
            //}

        }


        private static string Reverse(string yourName)//
        {
            char[] reverse = yourName.ToCharArray();
            Array.Reverse(reverse);
            return new String(reverse);
        }

        private static void SplitAndForeach()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine() ?? "";
            string[] nameList = names.Split(',');
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine();

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }

        }

        private static void SplitAndForeach_WithBreak()
        {
            Console.Write("Enter names in a list (like Maria, Peter,Lisa): ");
            string names = Console.ReadLine() ?? "";
            string[] nameList = names.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (var name in nameList)
            {
                if (name == "Zelda") break;
                Console.WriteLine($"{name} Andersson");

            }
        }

        public static bool ForeachEnterNames(string input)
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");

            var nameList = new List<string>();
            //var input = Console.ReadLine();

            var names = input.Split(',');//Array


            foreach (var name in names)
            {
                nameList.Add(name);//Lägger in namnen i listan               
            }
                        

            //Console.Write("Enter a surname: ");
            //Console.WriteLine();
            //var surname = Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            bool allowZelda = false;
            if (nameList.Contains("AllowZelda"))

            {                
                nameList.Remove("AllowZelda");
                allowZelda = true;
                               
            }

            foreach (var name in nameList)
            {
                if (name == "Zelda" && !allowZelda)
                    return true;
                    //break;

                Console.WriteLine(name+" Andersson");

            }

            
            Console.WriteLine();
            Console.ResetColor();
            return false;

        }

        private static void GuessTheNumber()
        {
            Random randomNumber = new Random();
            int guess = randomNumber.Next(1, 101);
           
            int count = 0;
            while (count<6)
            {
                Console.WriteLine("Guess the number (1-100)");
                count++;
                int myGuess = Convert.ToInt32(Console.ReadLine());
                if (guess == myGuess)
                    Console.WriteLine("Correct");
                else if (guess>myGuess)
                    Console.WriteLine("To low");
                else
                    Console.WriteLine("To high");

            }
            
            Console.WriteLine();

        }
        public static string EnterNumber2(int number, int compare)
        {
            Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Compare with: ");
            //int compare = Convert.ToInt32(Console.ReadLine());

             Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
                    

            //answer = (number > compare) ? "higher than": (number < compare) ? "lower than" : "equal";
            string answer = (number > compare) ? "Higher than" : (number == compare) ? "Equal" : "Lower than";


            Console.WriteLine(answer);

            Console.ResetColor();
            Console.WriteLine();
            return answer;
           

        }




        public static void EnterNumber()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Compare with: ");
            int compare = Convert.ToInt32(Console.ReadLine());

            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            string message;

            if (number < compare)
                message = $"Lower than {compare}";

            //Console.WriteLine($"Lower than {compare}");
            else if (number == compare)
                message = $"Equal to {compare}";

            //Console.WriteLine($"Equal to {compare}");
            else
                message = $"Higher than {compare}";
            // Console.WriteLine($"Higher than {compare}");
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();

        }

        

    }
}
