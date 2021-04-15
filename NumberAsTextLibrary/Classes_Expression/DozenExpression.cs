using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class DozenExpression : Expression
    {
        public override string Zero() { return "zero "; } 

        public override string One() { return "ten "; }  

        public override string Two() { return "twenty "; } 
        
        public override string Three() { return "thirty "; }
        
        public override string Four() { return "forty "; }  

        public override string Five() { return "fifty "; } 
        
        public override string Six() { return "sixty "; }  

        public override string Seven() { return "seventy "; } 
        
        public override string Eight() { return "eighty "; } 
        
        public override string Nine() { return "ninety "; }
    }
}
