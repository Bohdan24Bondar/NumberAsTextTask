using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumberAsTextLibrary;

namespace NumberAsTextTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController application = new ConsoleController("1878787");
            application.Run();
            Console.ReadKey();
        }
    }
}
