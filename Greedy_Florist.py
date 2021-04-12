def getMinimumCost(k, c):
    total = 0
    multiplier = 0
    counter = 0
    
    c.sort(reverse = True)
    for i in range(len(c)):
        total += (multiplier + 1) * c[i]
        counter += 1

        if counter == k:
            counter = 0
            multiplier += 1

    return total
