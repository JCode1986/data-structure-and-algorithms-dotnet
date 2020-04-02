using MyStacks.Classes;
using System;

namespace MultiBracketValidation
{
    public class BracketValidation
    {
        public MyStack<char> stack = new MyStack<char>();

        /// <summary>
        /// Method that returns a boolean if all stack has an opening and closing match
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>boolean</returns>
        public bool ValidateBrackets(string value)
        {
            foreach (char character in value)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (character == '}' && stack.Peek() != '{' ||
                        character == ')' && stack.Peek() != '(' ||
                        character == ']' && stack.Peek() != '[')
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.IsEmpty();
        }
    }
}
