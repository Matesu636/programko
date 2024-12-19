using System;
using System.Linq.Expressions;

namespace Kalkulackabuilder
{
    class Program
    {
        static void Main()
        {

            IExpression resultExpression = new ExpressionBuilder(7).Add(14).Add(new ExpressionBuilder(5).Multiply(1).Multiply(1).Build()).Build();

            Console.WriteLine(resultExpression.ToString() + " = " + resultExpression.Evaluate());


        }
    }

}