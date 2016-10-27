using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name("Vardy","Jamie","Onaga");
            Department department = new Department("Agric Science");
            Student chisom = new Student(name,department);

            Console.WriteLine("Press 1 to create student");
            Console.WriteLine("Press 2 to view student");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You pressed 1.. that mean you want to create a student");

            }
            Console.ReadKey();
        }
    }
}
