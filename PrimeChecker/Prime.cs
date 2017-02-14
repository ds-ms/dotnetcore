using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeChecker
{
    public static class Prime
    {
        public static bool IsPrime(int number)
        {
            if (number < 0) return false;
            if (number <= 3) return true;

            for(int i = 2; i <= number / 2; i ++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
