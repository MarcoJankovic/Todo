using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    public class PersonSequencer
    {

        private static int personId;

        public static int NextPersonId()  // Method
        {
            return personId++;
        }
        public static void Reset()  // Method
        {
            personId = 0;
        }
    }
}
