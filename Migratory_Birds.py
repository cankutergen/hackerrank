def migratoryBirds(arr):
    dict = {}
    max_count = 0
    max_type = 0
    arr.sort()

    for i in arr:
        if i not in dict:
            dict[i] = 1
        else:
            dict[i] += 1

    for key in dict:
        if dict[key] > max_count:
            max_count = dict[key]
            max_type = key

    return max_type
