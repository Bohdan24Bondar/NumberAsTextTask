using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsTextLibrary
{
    public class Interpretator
    {
        public void Interpret(Context context)
        {
            Expression expresion;
            NormalizeNumber(context);

            while (context.Input.Length > 0)
            {
                if (context.Input[0] != '0')
                {
                    expresion = new UnitExpression();
                    string result = expresion.GetNumberInWord(context.Input[0]);

                    context.Output += string.Format("{0}hundred ", result);
                }

                if (context.Input[1] != '0')
                {
                    char currentNumberic;
                    if (context.Input[1] == '1')
                    {
                        expresion = new TenExpression();
                        currentNumberic = context.Input[Constants.NUMBERIC_INDEX];
                    }
                    else
                    {
                        expresion = new DozenExpression();
                        currentNumberic = context.Input[1];
                    }

                    context.Output += expresion.GetNumberInWord(currentNumberic);

                }

                if ((context.Input[1] != '1') && (context.Input[Constants.NUMBERIC_INDEX] != '0'))
                {
                    expresion = new UnitExpression();
                    context.Output += expresion.GetNumberInWord(context.Input[Constants.NUMBERIC_INDEX]);
                }

                AddCategory(context);
                //AddEnding(context);
                context.Input = context.Input.Substring(Constants.CATEGORY_LENGHT, 
                        context.Input.Length - Constants.CATEGORY_LENGHT);
            }
        }

        private void AddEnding(Context context)
        {
            if ((context.Input[1] != '1') && (context.Input[2] != '1'))
            {
                context.Output += 's';
            }
        }

        private void AddCategory(Context context)
        {
            if (context.Input.Length / Constants.CATEGORY_LENGHT < Constants.MIN_LENGHT)
            {
                return;
            }

            int category = context.Input.Length / Constants.CATEGORY_LENGHT;

            switch ((NumberCategory)category)
            {
                case NumberCategory.thousand:
                    context.Output += string.Format("{0} ", NumberCategory.thousand.ToString());
                    break;
                case NumberCategory.million:
                    context.Output += string.Format("{0} ", NumberCategory.million.ToString());
                    break;
                case NumberCategory.billion:
                    context.Output += string.Format("{0} ", NumberCategory.billion.ToString());
                    break;
                default:
                    break;
            }
        }

        private void NormalizeNumber(Context context)
        {
            if (context.Input.Length % Constants.CATEGORY_LENGHT == 0)
            {
                return;
            }

            int categoryCount = (context.Input.Length / Constants.CATEGORY_LENGHT) + 1;
            context.Input = context.Input.PadLeft(categoryCount * Constants.CATEGORY_LENGHT, '0');
        }
    }
}
