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
        

        public UnaryExpression(IExpression operand )
        {
            this.operand = operand;
            
        }

        public abstract double Evaluate();


        public abstract string GetString();
        
    }
}