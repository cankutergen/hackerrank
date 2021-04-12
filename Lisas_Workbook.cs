static int workbook(int n, int k, int[] arr) {
            var pageNumber = 0;
            var increasePageNumber = true;
            var dict = new Dictionary<int, List<int>>(); // pagenumber with questions
            for (int i = 0; i < arr.Length; i++)
            {
                if(increasePageNumber)
                    pageNumber += 1;

                for (int j = 0; j < arr[i]; j++)
                {
                    increasePageNumber = true;
                    if (!dict.ContainsKey(pageNumber))
                    {
                        dict.Add(pageNumber, new List<int>() { j + 1 });
                    }
                    else
                    {
                        dict[pageNumber].Add(j + 1);
                    }

                    if ((j + 1) % k == 0)
                    {
                        pageNumber += 1;
                        increasePageNumber = false;
                    }
                }
            }

            var res = 0;
            foreach (var key in dict.Keys)
            {
                if (dict[key].Contains(key))
                    res++;
            }
            
            return res;

    }
