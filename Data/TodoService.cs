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
        private static Models.Todo[] todos = new Models.Todo[0];

        public int Size()
        {
            return todos.Length;
        }

        public Models.Todo[] FindAll()
        {
            //return people = new Person[0];
            return todos;
        }

        public Models.Todo FindById(int id)
        {
            return todos[id];
        }

        public Models.Todo CreateNewTodo(string description)
        {
            Models.Todo newTodo = new Models.Todo(TodoSequencer.Todos(), description);
            todos.Append(newTodo);
            return newTodo;
        }

        public void Clear()
        {
            // people.ToList().Clear(); //
            todos = new Models.Todo[0];
        }

        public Models.Todo[] FindByDoneStatus(bool doneStatus)
        {
            Models.Todo[] statusDone = new Models.Todo[0];

            foreach (Models.Todo todo in todos)
            {
                if (todo.Done == doneStatus)
                {
                    statusDone.Append(todo);
                }
            }
            return statusDone;
        }

        public Models.Todo[] FindByAssignee(Person assignee)
        {
            Models.Todo[] assigneeArray = new Models.Todo[0];

            foreach (Models.Todo todoitem in todos)
            {
                if(todoitem.MyAssignee == assignee)
                {
                    Array.Resize(ref assigneeArray, assigneeArray.Length + 1);
                    assigneeArray[assigneeArray.Length - 1] = todoitem;

                   // assigneeArray.Append(todoitem);
                }
            }
            return assigneeArray;

        }

    }

}