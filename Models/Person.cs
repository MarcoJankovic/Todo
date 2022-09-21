using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Person
    {
        private readonly int Id; // field
        private string? FirstName;
        private string? LastName;

        public Person(int id, string firstName, string lastName)  // Constructor

        {
            this.Id = id;
            FirstName = firstName;
            LastName = lastName;

        }

        public int id
        {
            get { return Id; }  // Readonly returns only id. No need for a set, since it's not suppose to take anything dynamicaly in.
        }

        public string? firstName
        {
            get { return FirstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }
                else
                {
                    FirstName = value;
                }
            }
        }

        public string? lastName
        {
            get { return LastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }
                else
                {
                    LastName = value;
                }
            }
        }


    }

}
