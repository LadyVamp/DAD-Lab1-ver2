using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll
{
    public class Class1 : MarshalByRefObject
    {
        public double add(double a, double b) //cal -> add
        {
            return a + b;
        }

        public double sub(double a, double b)
        {
            return a - b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }

        public double div(double a, double b)
        {
            return a / b;
        }
    }
}
