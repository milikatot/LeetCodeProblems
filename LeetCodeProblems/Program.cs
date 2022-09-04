using LeetCodeProblems.Problems;


Solution26 solution = new();

int[] nums = { 1, 1, 2 }; // Input array
int[] expectedNums = { 1, 2 }; // The expected answer with correct length

int k = Solution26.RemoveDuplicates(nums); // Calls your implementation

for (int i = 0; i < expectedNums.Length; i++)
{
    var b = nums[i] == expectedNums[i];
}

//var dd = solution.RemoveDuplicates(nums);

Console.ReadLine();
