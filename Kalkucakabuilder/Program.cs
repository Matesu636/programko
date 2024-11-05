using System;
using System.Linq.Expressions;
using Kalkulackabuilder;

class Program
{
    static void Main()
    {



        IExpression expr1 = new ExpressionBuilder(3).Add(12).Build();
       
        
        Console.WriteLine(expr1.GetString()); 
    }
}