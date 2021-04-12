def pairs(k, arr):
    arr.sort()
    count = 0
    for i in range(len(arr)):
        target = arr[i] + k
        val = binarySearch(arr, target, i, len(arr) - 1)
        if val != -1:
            count += 1

    return count
