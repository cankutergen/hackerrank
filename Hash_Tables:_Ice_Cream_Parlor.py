def whatFlavors(cost, money):
    h = {}
    for i, num in enumerate(cost):
        n = money - num
        if n not in h:
            h[num] = i
        else:
            print(h[n] + 1, i + 1)
