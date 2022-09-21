using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    internal class Todo
    {
        private readonly int Id;
        private string? Description;
        private bool Done;


        public Todo(int id, string description)
        {
            this.Id = id;
            Description = description;          
        }

        public int id
        {
            get { return Id; }

        }

        public string? description
        {
            get { return Description; }
            set { Description = value; }
        }



    }
}
