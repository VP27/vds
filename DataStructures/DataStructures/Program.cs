using DataStructures.Problems;
using DataStructures.Search;
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
        private static BinarySearch binarySearch = new BinarySearch();

        public static void Main(string[] args)
        {
            // check Balanced Paranthesis expression
            // CheckBalancedParanthesis();

            // search element using binary search
            SearchElement();
            Console.ReadKey();
        }

        private static void CheckBalancedParanthesis()
        {
            var input = "]";
            var result = paranthesisEvaluator.CheckBalanceParanthesis(input) ? "Yes, balanced expression" : "No, not a balanced expression";
            Console.WriteLine(result);
        }

        private static void SearchElement()
        {
            int[] array = new int[] { 3, 4, 5, 6, 7, 8, 9 };

            var index = binarySearch.Search(7, array, 0, array.Length);
            Console.WriteLine("Element at index {0}", index);
        }
    }
}
