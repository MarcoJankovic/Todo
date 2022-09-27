using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Data
{
    public class PeopleService
    {
        private static Person[] people = new Person[0];


        public int Size()
        {
            return people.Length;
        }

        public Person[] FindAll()
        {
            //return people = new Person[0];
            return people;
        }

        public Person FindById(int personId)
        {
            return people[personId];
        }

        public Person CreateNewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            people.Append(newPerson);
            return newPerson;
        }
        public void Clear()
        {
            // people.ToList().Clear(); //
            people = new Person[0];
        }
    }
}





