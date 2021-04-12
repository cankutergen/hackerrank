static string twoStrings(string s1, string s2) {
            var arr1 = s1.ToArray();
            var arr2 = s2.ToArray();

            var dict = new Dictionary<char, int>();
            foreach (var item in arr1)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }

            foreach (var item in arr2)
            {
                if (dict.ContainsKey(item))
                {
                    return "YES";
                }
            }

            return "NO";

    }
