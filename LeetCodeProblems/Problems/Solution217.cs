
namespace LeetCodeProblems.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/?envType=study-plan&id=data-structure-i
    /// </summary>
    internal class Solution217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                visited.Add(nums[i]);
            }

            return visited.Count != nums.Length;

        }
    }
}
