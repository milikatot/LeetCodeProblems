
namespace LeetCodeProblems.Problems;

internal class Solution26
{
    public static int RemoveDuplicates(int[] nums)
    {
        int j = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                nums[j] = nums[i];
                j++;
            }


        }
        nums[j++] = nums[nums.Length - 1];

        return j;
    }
}
