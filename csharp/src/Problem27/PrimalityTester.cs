using System;
using System.Collections;
using System.Collections.Generic;
class PrimalityTester
{
    private ISet<int> primes = new HashSet<int>();
    private int largestNumberTested = 0;

    public bool isPrime(int p)
    {
        if (p > largestNumberTested)
        {
            extendSieve(p);
        }

        return primes.Contains(p);
    }

    private void extendSieve(int upperBound)
    {
        BitArray sieve = new BitArray(upperBound + 1);
        sieve[0] = true;
        sieve[1] = true;

        for (int i = 2; i < sieve.Length; i++)
        {
            if (!sieve[i])
            {
                for (int j = 2*i; j < Math.Sqrt(upperBound); j = j + i)
                {
                    sieve[j] = true;
                }
            }
        }

        primes = (new List<Boolean>(sieve))
    }


}