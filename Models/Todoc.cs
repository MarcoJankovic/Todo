using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    internal class Todoc
    {
        private readonly int Id;  // Field  -- Here we declare what we are using
        private string? Description; // Field
        private bool Done;   // Field


        public Todoc(int id, string description)  // This is the Constructor that takes 2 arguments inside paramenters 
        {
            this.Id = id;
            Description = description;          
        }

        public int id  // Here we declare properties
        {
            get { return Id; }   // And returning value

        }

        public string? description // Here we declare properties
        {
            get { return Description; }  // And returning value
            set { Description = value; }
        }



    }
}
