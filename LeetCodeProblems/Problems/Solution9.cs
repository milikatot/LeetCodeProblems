
namespace LeetCodeProblems.Problems;

internal class Solution9
{
    public bool IsPalindrome(int x)
    {        
        char[] j = x.ToString()
                         .ToArray()
                         .Reverse()
                         .ToArray();
        string reverse = new(j);

        return string.Equals(x.ToString(), reverse, StringComparison.OrdinalIgnoreCase);
    }
}
