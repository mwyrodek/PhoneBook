using System;
using System.Runtime.InteropServices;

namespace PhoneBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            var phoneBook = new PhoneBook();
            while (running)
            {
                Console.WriteLine("What Do you want?");
                var readLine = Console.ReadLine();
                var comands = readLine.Split(' ');
                switch (comands[0])
                {
                    case "Location":
                            Console.WriteLine(value: phoneBook.EmployesFromLocation(comands[1]));
                        break;
                     default:
                         throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}