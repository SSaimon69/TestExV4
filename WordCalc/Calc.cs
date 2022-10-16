using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCalc
{
    public class Calc
    {
        public Dictionary<string, int> CalculateWordSingle(string text)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            string[] separators = { ",", ".", " ", " ", ";", ":", "?", "!", "\"", "(", ")", "—", "–", "[", "]", "»", "«" };

            string[] masWord = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < masWord.Length; i++)
            {
                if (map.ContainsKey(masWord[i])) map[masWord[i]]++;
                else map.Add(masWord[i], 1);
            }
            return map;
        }

        public ConcurrentDictionary<string, int> CalculateWordMulti(string text)
        {
            ConcurrentDictionary<string, int> map = new ConcurrentDictionary<string, int>();
            string[] separators = { ",", ".", " ", " ", ";", ":", "?", "!", "\"", "(", ")", "—", "–", "[", "]", "»", "«" };

            string[] masWord = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Parallel.For(0, masWord.Length - 1, n =>
            {
                map.AddOrUpdate(masWord[n], 1, (key, value) => value + 1);
            });
            return map;
        }
    }
}
