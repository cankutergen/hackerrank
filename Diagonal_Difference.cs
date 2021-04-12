    public static int diagonalDifference(List<List<int>> arr)
    {
        var leftToRight = new List<int>();
        var righToLeft = new List<int>();;
        
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr[i].Count; j++)
            {
                if(i == j)
                {
                    leftToRight.Add(arr[i][j]);
                }

                if(i + j == arr.Count - 1)
                {
                    righToLeft.Add(arr[i][j]);
                }
            }
        }
        
        var res =  leftToRight.Sum() - righToLeft.Sum();
        return Math.Abs(res);
    }
