    static void miniMaxSum(int[] arr) {
            Array.Sort(arr);

            var maxSumArray = arr.Skip(1).ToArray();

            var minSumArray = arr.Take(arr.Length - 1);

            Int64 max = 0;
            Int64 min = 0;

            foreach (var item in maxSumArray)
            {
                max += item;
            }

            foreach (var item in minSumArray)
            {
                min += item;
            }

            Console.WriteLine($"{min} {max}");

    }
