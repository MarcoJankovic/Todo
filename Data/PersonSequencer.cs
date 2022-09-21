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

        private static int PersonId;

        public static void NextPersonId()  // Method
        {           
              PersonId++;
        }
        public static void Reset()  // Method
        {
            PersonId = 0;
        }

    }
}
