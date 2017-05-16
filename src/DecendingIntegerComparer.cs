using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class DecendingIntegerComparer : IComparer<int>
    {
        public int Compare(int left, int right)
        {
            if (left == right) return 0;
            if (left < right) return 1;
            if (left > right) return -1;
            throw new ArgumentException("what the heck?");
        }
    }
}
