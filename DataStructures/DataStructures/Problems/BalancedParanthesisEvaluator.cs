using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public class BalancedParanthesisEvaluator
    {
        private Dictionary<char, char> paranthesisPairs;

        public BalancedParanthesisEvaluator()
        {
            paranthesisPairs = new Dictionary<char, char> {
                { '{', '}' }, { '[', ']' }, { '(', ')' }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression">
        /// e.g. []
        /// [{abcd}]
        /// </param>
        /// <returns></returns>
        public bool CheckBalanceParanthesis(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return false;

            if (expression.Length == 1)
                return false;

            Stack<char> charStack = new Stack<char>();
            char[] chars = expression.ToCharArray();
            
            if(!(chars.Contains('{') || chars.Contains('[') || chars.Contains('(')))
                return false;

            foreach (char c in chars)
            {
                if (paranthesisPairs.Keys.Contains(c))
                {
                    charStack.Push(c);
                }

                if (charStack.Count > 0)
                {
                    var peekValue = charStack.Peek();

                    if (paranthesisPairs.Keys.Contains(peekValue))
                    {
                        if (c == paranthesisPairs[peekValue])
                        {
                            charStack.Pop();
                        }
                    }
                }
            }

            return charStack.Count == 0;
        }
    }
}
