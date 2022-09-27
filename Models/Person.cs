using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Person
    {
        private readonly int id; // field
        private string? firstName;
        private string? lastName;

        public Person(int id, string firstName, string lastName)  // Constructor

        {
            this.id = id;
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public int Id
        {
            get { return id; }  // Readonly returns only id. No need for a set, since it's not suppose to take anything dynamicaly in.
        }

        public string? FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string? LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }


    }

}
