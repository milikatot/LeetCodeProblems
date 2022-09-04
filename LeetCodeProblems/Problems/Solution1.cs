
namespace LeetCodeProblems.Problems;

internal class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] sumNums = new int[2];

        if (nums.Length == 0)
            return sumNums;

        for (int i = 0; i < nums.Length; i++)
            for (int j = 1; j < nums.Length; j++)
                if (i != j && nums[i] + nums[j] == target)
                {
                    sumNums[0] = i;
                    sumNums[1] = j;
                    return sumNums;
                }

        return sumNums;
    }
}
