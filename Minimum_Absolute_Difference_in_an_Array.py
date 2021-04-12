def minimumAbsoluteDifference(arr):
    arr.sort(reverse = True)

    min_diff = sys.maxsize
    for i in range(len(arr) - 1):
        
        curr_diff = abs(arr[i] - arr[i + 1])
        if curr_diff < min_diff:
            min_diff = curr_diff

    return min_diff

