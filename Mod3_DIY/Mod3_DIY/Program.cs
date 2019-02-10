using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_DIY
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            // Code to finish getting the rest of the student data
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            return firstName;
           
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
    }
}
