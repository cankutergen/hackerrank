def stepPerms(n):
    x = [1, 2, 3]
    memo = {}
    res = num_ways(n, x, memo)
    return res % (pow(10, 10) + 7)
    
def num_ways(n, x, memo):
    if n in memo:
        return memo[n]

    if n == 0:
        memo[n] = 1
        return 1
    
    total = 0
    for i in x:
        if n - i >= 0:
            total += num_ways(n - i, x, memo)

    memo[n] = total
    return total
