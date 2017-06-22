using System;
using System.Collections.Generic;
using System.Linq;

namespace SumDigPower
{
    public class SumDigPower
    {
        public List<long> sumDigPow(long a, long b)
        {

            List<long> result = new List<long>();

            for (long i = a; i < b; i++)
            {

                List<long> longs = new List<long>();

                String temp = i.ToString();

                // Split values
                for (int j = 0; j < temp.Length; j++)
                {
                    longs.Add(Convert.ToInt64(temp[j].ToString()));
                }

                // Create sum
                long sum = 0;
                for (int j = 1; j <= longs.Count(); j++)
                {
                    sum += (long)Math.Pow(longs[j - 1], j);
                }

                // Test if sum is equal
                if (sum == i)
                {
                    result.Add(sum);
                }

            }

            return result;

        }
    }
}
