using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class SubtractionExpression : BinaryExpression
    {
        public SubtractionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }

        public override string GetString()
        {
            throw new NotImplementedException();
        }
    }
}