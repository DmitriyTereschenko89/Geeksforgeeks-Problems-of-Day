using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_represantation_next_number
{
    internal class Solution
    {
        private void Swap(List<char> arr)
        {
            int l = 0;
            int r = arr.Count - 1;
            while (l < r)
            {
                (arr[r], arr[l]) = (arr[l], arr[r]);
                ++l;
                --r;
            }
        }

        public string binaryNextNumber(string s)
        {
            List<char> number = s.ToCharArray().ToList();
            Swap(number);
            int bit = number[0] - '0';
            int sum = bit + 1;
            number[0] = (char)((sum % 2) + '0');
            int remainder = sum / 2;
            for (int i = 1; i < number.Count && remainder > 0; ++i)
            {
                bit = number[i] - '0';
                sum = bit + remainder;
                number[i] = (char)((sum % 2) + '0');
                remainder = sum / 2;
            }

            if (remainder > 0)
            {
                number.Add((char)(remainder + '0'));
            }

            Swap(number);
            number = number.SkipWhile(x => x == '0').ToList();

            return new string(number.ToArray());
        }
    }
}
