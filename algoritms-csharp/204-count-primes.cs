using System;

public class CountPrimesSolution {
    public int CountPrimes(int n) {
        if(n<=2)
            return 0;
        bool[] numbers = new bool[n];
        for(int i=2; i <= (int) Math.Sqrt(n); ++i)
        {
            if(numbers[i] == false)
            {
                for(int j = i*i; j<n; j+=i)
                    numbers[j] = true;
            }
        }
        
        int countOfPrimes = 0;
        for(int i=2; i<n; i++)
        {
            if(numbers[i] == false)
                ++countOfPrimes;
        }
        
        return countOfPrimes;
    }
}