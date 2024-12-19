using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class NumberExpression : IExpression
    {
        private double value { get; set; }

        public NumberExpression(double value)
        {
            this.value = value;
        }

        public double Evaluate()
        {
            return value;
        }

        public string ToString()
        {
            return value.ToString(); 
        }
    }
}