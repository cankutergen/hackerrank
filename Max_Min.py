def maxMin(k, arr):
    arr.sort()
    i = 0
    ans = arr[k-1] - arr[0]  #initiation
    for i in range(len(arr) - k + 1):
        temp = arr[i + k - 1] - arr[i]
        if temp < ans:
            ans = temp
    return ans
