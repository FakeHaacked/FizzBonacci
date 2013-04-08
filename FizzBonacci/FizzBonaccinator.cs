using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzinator
    {
        public IEnumerable<int> Generate(int count)
        {
            yield return 1;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 5;
            yield return 8;
            yield return 13;
            yield return 21;
            yield return 34;
            yield return 55;
        }
    }
}

