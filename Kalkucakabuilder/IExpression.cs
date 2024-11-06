using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulackabuilder
{
    public interface IExpression
    {
        double Evaluate();
        string GetString();
    }

    
}