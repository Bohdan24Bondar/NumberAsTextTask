using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class TenExpression : Expression
    {
        public override string Zero() { return "ten "; }

        public override string One() { return "eleven "; } 

        public override string Two() { return "twelve "; } 

        public override string Three() { return "thirteen "; } 

        public override string Four() { return "fourteen "; } 

        public override string Five() { return "fifteen "; } 

        public override string Six() { return "sixteen "; }
        
        public override string Seven() { return "seventeen "; }
        
        public override string Eight() { return "eighteen "; } 

        public override string Nine() { return "nineteen "; }
    }
}
