def pickingNumbers(a):
    a.sort()

    curr_count = 1
    max_count = 1

    for i in range(len(a)):
        j = i + 1
        while j < len(a) and (a[i] == a[j] or abs(a[i] - a[j]) == 1):
            j += 1
            curr_count += 1

        if curr_count > max_count:
            max_count = curr_count
        curr_count = 1
        
    return max_count
