using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class NegationExpression : UnaryExpression
    {
        public NegationExpression(IExpression operand) : base(operand)
        {
        }

        public override double Evaluate()
        {
            return -operand.Evaluate();
        }

        public override string GetString()
        {
            throw new NotImplementedException();
        }
    }
}