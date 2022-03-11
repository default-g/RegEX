using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEX.Models
{
    public class RegExFinder
    {
        public string[] GetMatches(string pattern, string input)
        {
            return new Regex(pattern).Matches(input)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
        }
    }
}
