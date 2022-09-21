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

        public static void NextPersonId()
        {           
              PersonId++;
        }
        public static void Reset()
        {
            PersonId = 0;
        }

    }
}
