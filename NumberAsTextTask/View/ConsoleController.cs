using NumberAsTextLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextTask
{
    class ConsoleController
    {
        private Viewer consoleViewer;
        public ConsoleController(string number)
        {
            Number = number;
            consoleViewer = new Viewer(string.Format("Number {0} as a phrase:", number)); //todo

        }

        public string Number { get; private set; }

        public void Run()
        {
            NumberValidator checker = new NumberValidator(Number);

            if (!checker.IsNumber())
            {
                consoleViewer.ShowExpression("instruction");//todod
                return;
            }

            if (!checker.HasRightLength())
            {
                consoleViewer.ShowExpression("instruction");//todo
                return;
            }

            Context destinationPhrase = new Context(Number);
            Interpretator transletor = new Interpretator();
            transletor.Interpret(destinationPhrase);
            consoleViewer.ShowExpression(destinationPhrase.Output);
        }

    }
}
