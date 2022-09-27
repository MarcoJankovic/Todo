using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data;
using Todo.Models;

namespace Todo.Data
{
    public class TodoService
    {
        private static Todoc[] todos = new Todoc[0];

        public int Size()
        {
            return todos.Length;
        }

        public Todoc[] FindAll()
        {
            //return people = new Person[0];
            return todos;
        }

        public Todoc FindById(int id)
        {
            return todos[id];
        }

        public Todoc CreateNewTodo(string description)
        {
            Todoc newTodo = new Todoc(TodoSequencer.Todos(), description);
            todos.Append(newTodo);
            return newTodo;
        }

        public void Clear()
        {
            // people.ToList().Clear(); //
            todos = new Todoc[0];
        }

        public Todoc[] FindByDoneStatus(bool doneStatus)
        {
            Todoc[] statusDone = new Todoc[0];

            foreach (Todoc todo in todos)
            {
                if (todo.done == doneStatus)
                {
                    statusDone.Append(todo);
                }
            }
            return statusDone;
        }

        public Todoc[] FindByAssignee(int personId)
        {

        }

    }

}