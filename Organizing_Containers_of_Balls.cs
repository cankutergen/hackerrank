static string organizingContainers(int[][] container) {
            List<long> capacities = new List<long>();
            List<long> typeCounts = new List<long>();

            // get container capacities
            foreach (var cap in container)
            {
                long sum = 0;
                foreach (var item in cap)
                {
                    sum += item;
                }

                capacities.Add(sum);
            }

            for (int i = 0; i < container.Length; i++)
            {
                for (int j = 0; j < container[i].Length; j++)
                {
                    if(typeCounts.Count != container[i].Length)
                    {
                        typeCounts.Add(container[i][j]);
                    }
                    else
                    {
                        typeCounts[j] = typeCounts[j] + container[i][j];
                    }
                }
            }

            var sortedCap = capacities.OrderBy(x => x).ToList();
            var sortedTypes = typeCounts.OrderBy(x => x).ToList();

            for (int i = 0; i < sortedCap.Count; i++)
            {
                if(sortedCap[i] != sortedTypes[i])
                {
                    return "Impossible";
                }
            }

            return "Possible";

    }
