using MyStacks.Classes;
using System;

namespace MultiBracketValidation
{
    public class BracketValidation
    {
        public MyStack<char> brackets = new MyStack<char>();

        /// <summary>
        /// Method that returns a boolean if all brackets has an opening and closing match
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>boolean</returns>
        public bool ValidateBrackets(string str)
        {
            foreach (char character in str)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    brackets.Push(character);
                }
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (character == '}' && brackets.Peek() != '{' ||
                        character == ')' && brackets.Peek() != '(' ||
                        character == ']' && brackets.Peek() != '[')
                    {
                        return false;
                    }
                    brackets.Pop();
                }
            }
            return brackets.IsEmpty();
        }
    }
}
