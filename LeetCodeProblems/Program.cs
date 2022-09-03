using LeetCodeProblems.Problems;


ListNode list1 = new()
{
    val = 2,
    next = new ListNode()
    {
        val = 4,
        next = new ListNode()
        {
            val = 3,

        }
    }
};
ListNode list2 = new()
{
    val = 5,
    next = new ListNode()
    {
        val = 6,
        next = new ListNode()
        {
            val = 4
        }
    }
};

Solution2 solution = new();

var dd = solution.AddTwoNumbers(list1, list2);

Console.ReadLine();
