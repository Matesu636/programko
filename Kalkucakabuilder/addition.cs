using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class AdditionExpression : BinaryExpression
    {
        public AdditionExpression(IExpression left, IExpression right, string operatorSymbol) : base(left, right, operatorSymbol)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() + right.Evaluate();
        }

    }
}