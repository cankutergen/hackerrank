    static int sockMerchant(int n, int[] ar) {
            int res = 0;
            var distinctArray = ar.Distinct().ToArray();
            foreach (var item in distinctArray)
            {
                var count = ar.Where(x => x == item).Count();
                var sockCount = (int)(count / 2);
                res += sockCount;
            }
            
            return res;
    }
