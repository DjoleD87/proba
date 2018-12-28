using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reversa game");

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your city of born: ");
            string city = Console.ReadLine();
            
            //DisplayResult(ReverseArray(firstName), ReverseArray(lastName), ReverseArray(city));
            DisplayResult(ReverseArray(firstName) + " " + ReverseArray(lastName) + " " + ReverseArray(city));
            
            Console.ReadLine();
        }
       private static string ReverseArray(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
            
        }
        /*private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(string.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }*/
        private static void DisplayResult(string message)
        {
            Console.Write(message);
        }

    }
}
