using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextTask
{
    class Viewer
    {
        public Viewer(string startMessage)
        {
            StartMessage = startMessage;
        }

        public string StartMessage { get; private set; }

        public void ShowExpression(string expression)
        {
            Console.Clear();
            Console.WriteLine(expression);
        }
    }
}
