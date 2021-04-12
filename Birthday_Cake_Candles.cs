    public static int birthdayCakeCandles(List<int> candles)
    {
        var max = candles.Max();

        return candles.Where(x => x == max).Count();
    }
