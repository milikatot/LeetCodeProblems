
namespace LeetCodeProblems.Problems;

internal class Solution17
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> res = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return res;

        Dictionary<char, string[]> lettersMap = new()
        {
            { '0', Array.Empty<string>() },
            { '1', Array.Empty<string>() },
            { '2', new string[3] { "a", "b", "c" }  },
            { '3', new string[3] { "d", "e", "f" }  },
            { '4', new string[3] { "g", "h", "i" }  },
            { '5', new string[3] { "j", "k", "l" }  },
            { '6', new string[3] { "m", "n", "o" }  },
            { '7', new string[4] { "p", "q", "r", "s" }  },
            { '8', new string[3] { "t", "u", "v" }  },
            { '9', new string[4] { "w", "x", "y", "z" }  }
        };

        res.Add(string.Empty);
        foreach (char d in digits)
        {
            IList<string> next = new List<string>();
            var letterList = lettersMap.FirstOrDefault(x => x.Key == d).Value.ToList();
            foreach (var letter in letterList)
            {
                foreach (string s in res)
                {
                    next.Add(s + letter);
                }
            }
            res = next;
        }

        return res;

        
    }
}
