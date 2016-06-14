using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Person newPerson = new Person(); abstract class can not create interface
            Student tommy = new Student(20, "tommy", "A123456");

            Console.WriteLine(tommy.ToString()); //ToString is method should include ()

        }
    }
}
