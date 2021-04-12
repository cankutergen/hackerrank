def missingNumbers(arr, brr):
    dict_a = {}
    dict_b = {}

    missing = []

    for i in arr:
        if i not in dict_a:
            dict_a[i] = 1
        else:
            dict_a[i] += 1

    for i in brr:
        if i not in dict_b:
            dict_b[i] = 1
        else:
            dict_b[i] += 1

    for key in dict_b:
        if key in dict_a:
            if dict_a[key] != dict_b[key]:
                missing.append(key)
        else:
            missing.append(key)
    missing.sort()
    return missing
