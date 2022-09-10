
namespace LeetCodeProblems.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    internal class Solution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s == string.Empty)
                return 0;

            HashSet<char> charsSet = new();
            int currentMax = 0,
                i = 0,
                j = 0;

            while (j < s.Length)
                if (!charsSet.Contains(s[j]))
                {
                    charsSet.Add(s[j++]);
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                    charsSet.Remove(s[i++]);

            return currentMax;
        }
    }
}
