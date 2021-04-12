    static void extraLongFactorials(int n) 
    {
        var memo = new BigInteger[n];
        var res = Factorial(n, memo);
        
        Console.WriteLine(res);
    }
    
    public static BigInteger Factorial(int n, BigInteger[] memo)
    {
        if(memo.ElementAtOrDefault(n - 1) != 0)
        {
            return n;
        }

        BigInteger res;
        if(n == 0 || n == 1)
        {
            res = 1;
            memo[n - 1] = 1;
        }
        else
            res = n * Factorial(n - 1, memo);

        memo[n - 1] = res;

        return res;
    }
