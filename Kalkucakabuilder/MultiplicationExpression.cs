﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    internal class MultiplicationExpression : BinaryExpression
    {
        public MultiplicationExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() * right.Evaluate();
        }

        public override string ToString()
        {
            return $"({left.ToString()} + {right.ToString()})";
        }
    }
}