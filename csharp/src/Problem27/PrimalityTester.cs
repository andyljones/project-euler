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
        BitArray sieve = new BitArray(upperBound + 1, true);
        sieve[0] = false;
        sieve[1] = false;

        for (int i = 0; i < Math.Sqrt(sieve.Length); i++)
        {
            if (sieve[i])
            {
                for (int j = 2*i; j < sieve.Length; j = j + i)
                {
                    sieve[j] = false;
                }
            }
        }

        ISet<int> newPrimes = new HashSet<int>();
        for (int i = 0; i < sieve.Length; i++)
        {
            if (sieve[i])
            {
                newPrimes.Add(i);
            }
        }

        primes = newPrimes;
        largestNumberTested = upperBound;
    }


}