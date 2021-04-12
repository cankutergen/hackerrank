def triplets(a, b, c):
    set_a = set(a)
    set_b = set(b)
    set_c = set(c)
    arr = []

    for i in set_a:    
        for j in set_b:
            sub_arr = []
            if i <= j:
                sub_arr.append(i)
                sub_arr.append(j)
                arr.append(sub_arr)

    count = 0
    for k in set_c:
        for sub_arr in arr:
            if sub_arr[1] >= k:
                count += 1

    return count
