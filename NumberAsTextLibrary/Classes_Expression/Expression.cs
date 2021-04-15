using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public abstract class Expression
    {
        public abstract string Zero();

        public abstract string One();

        public abstract string Two();

        public abstract string Three();

        public abstract string Four();

        public abstract string Five();

        public abstract string Six();

        public abstract string Seven();

        public abstract string Eight();

        public abstract string Nine();

        public virtual string GetNumberInWord(char numberic)
        {
            string numberInString = string.Empty;

            switch (numberic)
            {
                case '0':
                    numberInString = Zero();
                    break;
                case '1':
                    numberInString = One();
                    break;
                case '2':
                    numberInString = Two();
                    break;
                case '3':
                    numberInString = Three();
                    break;
                case '4':
                    numberInString = Four();
                    break;
                case '5':
                    numberInString = Five();
                    break;
                case '6':
                    numberInString = Six();
                    break;
                case '7':
                    numberInString = Seven();
                    break;
                case '8':
                    numberInString = Eight();
                    break;
                case '9':
                    numberInString = Nine();
                    break;
                default:
                    break;
            }

            return numberInString;
        }
    }
}
