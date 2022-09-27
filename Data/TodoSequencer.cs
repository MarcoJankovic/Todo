using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    public class TodoSequencer
    {
        private static int todos;
        public static int Todos()
        {
            return todos++;
        }

        public static void Reset()
        {
            todos = 0;
        }

    }
}
