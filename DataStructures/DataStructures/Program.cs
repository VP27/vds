using DataStructures.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Program
    {
        private static BalancedParanthesisEvaluator paranthesisEvaluator = new BalancedParanthesisEvaluator();

        public static void Main(string[] args)
        {
            // check Balanced Paranthesis expression
            CheckBalancedParanthesis();
            Console.ReadKey();
        }

        private static void CheckBalancedParanthesis()
        {
            var input = "]";
            var result = paranthesisEvaluator.CheckBalanceParanthesis(input) ? "Yes, balanced expression" : "No, not a balanced expression";
            Console.WriteLine(result);
        }
    }
}
