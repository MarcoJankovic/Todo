using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Todo
    {
        private readonly int id;  // Field  -- Here we declare what we are using
        private string? description; // Field
        private bool done;   // Field
        private Person? assignee;

        public Todo(int id, string? description)  // This is the Constructor that takes 2 arguments inside paramenters 
        {
            this.id = id;
            Description = description;
        }

        public int Id  // Here we declare properties
        {
            get { return id; }   // And returning value

        }

        public string? Description // Here we declare properties
        {
            get { return description; }  // And returning value
            set { description = value; }
        }
        public bool Done
        {
            get
            {
                return done;
            }          
        }

        public Person? MyAssignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

    }
}
