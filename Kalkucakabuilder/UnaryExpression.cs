using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal abstract class UnaryExpression : IExpression
    {
        protected IExpression operand;
        protected string operatorSymbol;

        public UnaryExpression(IExpression operand, string operatorSymbol)
        {
            this.operand = operand;
            this.operatorSymbol = operatorSymbol;
        }

        public virtual double Evaluate()
        {
            return operatorSymbol == "-" ? -operand.Evaluate() : operand.Evaluate();
        }

        public string GetString()
        {
            return operatorSymbol + "(" + operand.GetString() + ")"; 
        }
    }
}