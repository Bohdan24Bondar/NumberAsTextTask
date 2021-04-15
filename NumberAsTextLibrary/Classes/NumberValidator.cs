using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class NumberValidator
    {
        public NumberValidator(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }

        public bool IsNumber()
        {
            return int.TryParse(Number, out _);
        }

        public bool HasRightLength()
        {
            return Number.Length <= Constants.MAX_NUMBERICS_COUNT;
        }
    }
}
