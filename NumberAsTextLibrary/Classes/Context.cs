using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class Context
    {
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
        public string Output { get; set; }
    }
}
