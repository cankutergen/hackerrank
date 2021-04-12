def powerSum(X, N):
    memo = {}
    return dp(X, N, 1, memo)

def dp(X, N, num, memo):

    if (X, num) in memo:
        return memo[(X, num)]

    value = X - num**N

    if value < 0:
        return 0
    elif value == 0:
        memo[(X, num)] = 1
        return 1
    else:
        memo[(X, num)] = dp(X, N, num + 1, memo) + dp(value, N, num + 1, memo)
        return memo[(X, num)]
