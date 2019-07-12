using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(5, 7, Operation.Add));
            Console.WriteLine(Calculator(5, 7, Operation.Divide));
            Console.WriteLine(Calculator(5, 7, Operation.Multiply));
            Console.WriteLine(Calculator(5, 7, Operation.Subtract));
            Console.ReadKey();
            
        }
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        static double Calculator(int x,int y, Operation op)
        {
            double result = 0;
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Divide:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Subtract:
                    result = (double)x / y;
                    break;
            }
            return result;
        }
    }
}
