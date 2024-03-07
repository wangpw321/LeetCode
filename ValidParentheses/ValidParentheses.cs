// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.


// Example 1:

// Input: s = "()"
// Output: true
// Example 2:

// Input: s = "()[]{}"
// Output: true
// Example 3:

// Input: s = "(]"
// Output: false


// Constraints:

// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(s[i]);
                    break;
                default:
                    break;
            }
            if (stack.Count > 0)
            {
                if (s[i] == ')' && stack.Peek() == '('
                || s[i] == ']' && stack.Peek() == '['
                || s[i] == '}' && stack.Peek() == '{')
                    stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}