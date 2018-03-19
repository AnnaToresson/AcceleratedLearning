using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            char separator= AskUserForSeparator();
            
            string[] newList; //skapar den utanför intervallet

            while (true)
            {
                
                var svar = GetInputFromUser();                
                newList = CreateArrayOfPeople(svar,separator);
                var isOk = Validation(newList);
                
                if (isOk == false)
                    continue;
                
                break;
                
            }
                                   
            RespondToUser(newList); //lägga till svarformat
        
        }

        private static void Everything()//Metod med allt
        {
            RespondToUser(AlmostEverything());
        }

        private static string[] AlmostEverything()
        {
            return CreateArrayOfPeople(GetInputFromUser());
        }

        private static void ListOfNames() //program utan uppdelning i metoder
        {

            Console.Write("Enter names separated by comma: ");
            var names = Console.ReadLine();
            var name = names.Split(',');//En array skapas
            AnswerColor();
            Console.WriteLine();

            foreach (var input in name)
            {
                Console.WriteLine($"***SUPER-{input.ToUpper().Trim()}***");
            }

            Console.ResetColor();
            Console.WriteLine();


        }



        private static string GetInputFromUser()
        {
            AskUserForSeparator();

            Console.Write("Enter names separated by separator: ");
            var names = Console.ReadLine();

            
            return names;

        }

        private static char AskUserForSeparator()
        {
            Console.Write("Choose separator: ");
            var decide = char.Parse(Console.ReadLine());
            char separator;

            if (decide == '%')
                separator = '%';

            else
                separator = ',';
            return separator;
           


        }

        private static string CleanUpArray(string names)
        {
            var namesChanged = names.Trim();
            return namesChanged;
        }


        private static string[] CreateArrayOfPeople(string namesChanged, char separator=',')
        {
            
            string[] nameArray = namesChanged.Split(AskUserForSeparator(), StringSplitOptions.RemoveEmptyEntries);
            
            //string[] nameArray = namesChanged.Split(',',StringSplitOptions.RemoveEmptyEntries);//för att vektorn ska vara noll i längd om tom

            return nameArray;

        }


        private static bool RespondToUser(string[] peopleArray)
        {
            AnswerColor();

            Console.WriteLine();

            foreach (var input in peopleArray)
            {

                //var regex = new Regex("a");
                //var result = regex.Replace(input, "X");
                //Console.WriteLine($"***SUPER-{result.ToUpper()}***");




                Console.WriteLine($"***SUPER-{input.ToUpper()}***");



            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return true;
           


        }

        private static bool Validation(string[] peopleArray)
        {

            if (peopleArray.Length ==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list don't contain any names");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                return false;
            }
            else
            {
                foreach (var item in peopleArray)
                {
                    if (item.Length < 2 || item.Length > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A person can only have 2 to 9 letters");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        return false;
                    }
                }
            }
            

            return true;
        }



        public static void AnswerColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;


        }



    }
}
