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
            Console.WriteLine("Write line");
            Console.WriteLine("Write \n line");
            Console.WriteLine("Write \" line");

            string firstname = "Justin";
            string lastname = "Prim";

            Console.WriteLine(lastname + " "+firstname);

            Console.WriteLine(lastname.Length);
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.Contains("Pr"));
            Console.WriteLine(firstname[2]);
            Console.WriteLine(lastname.IndexOf("i"));
            Console.WriteLine(firstname.Substring(1));
            Console.WriteLine(lastname.Substring(1,2));

            Console.ReadLine();
        }
    }
}
