
namespace LeetCodeProblems.Problems;

internal class Solution9
{
    public bool IsPalindrome(int x)
    {
        if (x == 0)
            return true;
        if (x < 10)
            return false;

        char[] j = x.ToString()
                         .ToArray()
                         .Reverse()
                         .ToArray();
        string reverse = new(j);

        return string.Equals(x.ToString(), reverse, StringComparison.OrdinalIgnoreCase);
    }
}
