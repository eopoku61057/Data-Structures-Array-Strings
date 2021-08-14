public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        Stack<char> stack = new Stack<char>();
        bool isBalanced = true;


        for (int i = 0; i < s.Length - 1; i++)
        {
            char c = s[i];
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
                continue;
            }
            if (!stack.Any())
                return false;

            if (c == ')')
            {
                if (stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                }
            }
            if (c == '}')
            {
                if (stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                }
            }
            if (c == ']')
            {
                if (stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                }
            }

        }
        if (!stack.Any())
        {
            return false;
        }
        if (isBalanced)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// working Java code 
class Solution
{
    public boolean isValid(String s)
    {
        Stack<Character> stack = new Stack<>();

        boolean isBalanced = true;

        for (int i = 0; i < s.length(); i++)
        {
            char ch = s.charAt(i);

            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.push(ch);
                continue;
            }

            if (stack.isEmpty())
            {
                return false;
            }

            if (ch == ')')
            {
                if (stack.peek() == '(')
                {
                    stack.pop();
                }
                else
                {
                    isBalanced = false;
                }
            }

            if (ch == '}')
            {
                if (stack.peek() == '{')
                {
                    stack.pop();
                }
                else
                {
                    isBalanced = false;
                }
            }

            if (ch == ']')
            {
                if (stack.peek() == '[')
                {
                    stack.pop();
                }
                else
                {
                    isBalanced = false;
                }
            }
        }
        if (!stack.isEmpty())
        {
            return false;
        }
        if (isBalanced)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}