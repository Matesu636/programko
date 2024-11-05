using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class NegationExpression : UnaryExpression
    {
        public NegationExpression(IExpression operand, string operatorSymbol) : base(operand,operatorSymbol)
        {
        }

        public override double Evaluate()
        {
            return -operand.Evaluate();
        }

    }
}