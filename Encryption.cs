static string encryption(string s) {
            s = s.Replace(" ", "");

            var sqrt = Math.Sqrt(s.Length);
            var rowCount = Math.Floor(sqrt);
            var colCount = Math.Ceiling(sqrt);
            
            if(rowCount * colCount < s.Length)
            {
                if (rowCount < colCount) rowCount++;
                else colCount++;
            }

            var lastRowSize = s.Length % colCount;

            List<string> list = new List<string>();
            var rowCounter = 0;
            var dict = new Dictionary<int, string>();
            for (int i = 0; i < s.Length; i += (int)colCount)
            {
                rowCounter += 1;
                var subStr = lastRowSize != 0 && rowCounter == rowCount ? s.Substring(i, (int)lastRowSize) : s.Substring(i, (int)colCount);

                list.Add(subStr);

                for (int j = 0; j < colCount; j++)
                {
                    if (!dict.ContainsKey(j))
                    {
                        dict.Add(j, subStr.ElementAt(j).ToString());
                    }
                    else
                    {
                        if(subStr.Length > j)
                            dict[j] = dict[j] + subStr.ElementAt(j).ToString();
                    }
                } 
            }

            var str = "";
            for (int i = 0; i < dict.Count; i++)
            {
                str += dict[i] + " ";
            }
            
            return str;

    }
