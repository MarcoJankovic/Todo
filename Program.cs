using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(10, "Marco", "Svensson");

            Console.WriteLine(person.id);

            Console.WriteLine(person.id + " " + person.firstName + " " + person.lastName);

        


            Console.ReadLine();

        }
    }
}