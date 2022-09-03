
using System.Text;

namespace LeetCodeProblems.Problems
{
    internal class Solution43
    {
        public string Multiply(string num1, string num2)
        {
            int[] inum1 = num1
                    .Where(n => char.IsDigit(n))
                    .Select(n => int.Parse(n.ToString()))
                    .ToArray();

            int[] inum2 = num2
                    .Where(n => char.IsDigit(n))
                    .Select(n => int.Parse(n.ToString()))
                    .ToArray();

            int[] product = new int[num1.Length + num2.Length];

            for (int i = 0; i < num1.Length; i++)
                for (int j = 0; j < num2.Length; j++)
                    product[i + j + 1] += inum1[i] * inum2[j];

            for (int i = product.Length - 1; i > 0; i--)
            {
                product[i - 1] += product[i] / 10;
                product[i] %= 10;
            }

            int pi = 0;
            while (pi < product.Length && product[pi] == 0)
            {

                if (++pi >= product.Length)
                    return "0";
            }

            StringBuilder sb = new();
            for (; pi < product.Length; pi++)
                sb.Append(product[pi]);

            return sb.ToString();
        }
    }
}
