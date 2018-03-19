using System;
using System.Collections.Generic;

namespace Modul1
{
    class Program
    {
        private static void Main(string[] args)
        {
            WithMethodsSimple();
            
        }

       
        private static void WithMethodsSimple()
        {
            string response = GetinputFromUser();
            string[] peopleArray = CreateArrayOfPeople(response, ',');

            RespondToUser(peopleArray);
        }
        private static string GetinputFromUser()
        {
            Console.Write("Enter a list of names: ");
            string answer = Console.ReadLine();
            return answer;
        }

       

        private static string[] CreateArrayOfPeople(string response, char separator =',')
        {
            string[] list = response.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return list;

        }

       

        private static void RespondToUser(string[] peopleArray)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if(peopleArray.Length==0)
            {
                Console.WriteLine("No people in the list");
                return;
            }

            foreach (string person in peopleArray)
            {
                Console.WriteLine($"***SUPER-{person.ToUpper()}***");
            }
        }


        
    }
}
