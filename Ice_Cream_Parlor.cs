static int[] icecreamParlor(int m, int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == m)
                    {
                        return new int[2]{i + 1, j + 1};
                    }
                }
            }
            
            return new int[2];

    }
