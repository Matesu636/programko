using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    public abstract class BinaryExpression : IExpression
    {
        protected IExpression left;
        protected IExpression right;
        protected string operatorSymbol;

        public BinaryExpression(IExpression left, IExpression right, string operatorSymbol)
        {
            this.left = left;
            this.right = right;
            this.operatorSymbol = operatorSymbol;
        }

        public  virtual double Evaluate()
        {
            return operatorSymbol switch
            {
                "+" => left.Evaluate() + right.Evaluate(),
                "-" => left.Evaluate() - right.Evaluate(),
                "*" => left.Evaluate() * right.Evaluate(),
                "/" => left.Evaluate() / right.Evaluate(),
            };
        }


        public string GetString()
        {
            return "(" + left.GetString() + " " + operatorSymbol + " " + right.GetString() + ")"; 
        }
    }
}