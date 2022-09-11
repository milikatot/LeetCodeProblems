
namespace LeetCodeProblems.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    internal class Solution20
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 2)
                return false;

            Dictionary<char,char> map = new()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };

            Stack<char> sign = new();

            int i = 0;

            while (i < s.Length)
            {
                if (map.Any(k => k.Key == s[i]))
                    sign.Push(s[i]);
                else
                {
                    var c = map.FirstOrDefault(k => k.Value == s[i]);

                    switch (c.Value)
                    {
                        case ')':
                            if (sign.Count > 0 && sign.Peek() == '(')
                                sign.Pop();
                            else 
                                return false;
                            break; 
                        case ']':
                            if (sign.Count > 0 && sign.Peek() == '[')
                                sign.Pop();
                            else 
                                return false;
                            break;
                        case '}':
                            if (sign.Count > 0 && sign.Peek() == '{')
                                sign.Pop();
                            else 
                                return false;
                            break;
                        default:
                            return false;
                    }
                }


                i++;
            }

            return sign.Count == 0;
        }
    }
}
