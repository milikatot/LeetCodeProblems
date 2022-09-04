
using System.Text;

namespace LeetCodeProblems.Problems;

internal class Solution8
{
    public int MyAtoi(string s)
    {
        s = s.Trim();

        if (string.IsNullOrEmpty(s))
            return 0;

        var array = s.ToArray();

        var sign = 1;
        var index = 0;

        StringBuilder builder = new();

        if ((array[index] == '-') || (array[index] == '+'))
        {
            sign = array[index] == '-' ? -1 : 1;
            index++;
        }

        while (index < array.Length)
        {
            if (char.IsDigit(array[index]))
            {
                builder.Append(array[index]);
            }
            else
                break;

            index++;
        }

        try
        {
            if (string.IsNullOrEmpty(builder.ToString()))
                return 0;

            return int.Parse(builder.ToString()) * sign;
        }
        catch
        {
            return sign < 0 ? int.MinValue : int.MaxValue;
        }
    }
}
