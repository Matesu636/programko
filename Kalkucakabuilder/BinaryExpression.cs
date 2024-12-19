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
        

        public BinaryExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
            
        }

        public abstract  double Evaluate();




        public abstract string ToString();
        
    }
}