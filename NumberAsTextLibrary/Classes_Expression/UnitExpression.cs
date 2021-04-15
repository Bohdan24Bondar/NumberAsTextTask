using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class UnitExpression : Expression
    {
        public override string Zero() { return "zero "; }

        public override string One() { return "one "; }

        public override string Two() { return "two "; }

        public override string Three() { return "three "; }

        public override string Four() { return "four "; }

        public override string Five() { return "five "; }

        public override string Six() { return "six "; }

        public override string Seven() { return "seven "; }

        public override string Eight() { return "eight "; }

        public override string Nine() { return "nine "; }
    }
}
