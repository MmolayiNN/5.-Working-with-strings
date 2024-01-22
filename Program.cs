using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will write \n wrap to next line");
            Console.WriteLine("This will \n print out the quotation mark.");

            string firstName = "Nelca";
            string lastName = "Mmolayi";
           
            Console.WriteLine(firstName + " " + lastName);  

           
            Console.WriteLine(lastName.Length);          
            Console.WriteLine(firstName.ToUpper());          
            Console.WriteLine(lastName.Contains("Mm"));           
            Console.WriteLine(firstName[0]);
            Console.Write("Index of a is: ");
            Console.WriteLine(lastName.IndexOf("a"));
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(lastName.Substring(1,2));
            Console.Read();











        }
    }
}
