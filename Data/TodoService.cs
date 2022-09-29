using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
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
            var newTodo = new Todoc(TodoSequencer.Todos(), description);
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
                if (todo.Done == doneStatus)
                {
                    statusDone.Append(todo);
                }
            }
            return statusDone;
        }

        public Todoc[] FindByAssignee(Person assignee)
        {
            Todoc[] assigneeArray = new Todoc[0];

            foreach (Todoc todoitem in todos)
            {
                if (todoitem.MyAssignee == assignee)
                {
                    Array.Resize(ref assigneeArray, assigneeArray.Length + 1);
                    assigneeArray[assigneeArray.Length - 1] = todoitem;

                }
            }
            return assigneeArray;
        }

        public Todoc[] FindUnassignedTodoItems()
        {
            Todoc[] assigneeArray = new Todoc[0];

            foreach (Todoc todoitem in todos)
            {
                if (todoitem == null)
                {
                    Array.Resize(ref assigneeArray, assigneeArray.Length);
                }
            }
            return assigneeArray;
        }
    }

}