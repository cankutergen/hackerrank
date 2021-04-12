def getMoneySpent(keyboards, drives, b):
    set_k = set()
    global_max = -1

    for x in keyboards:
        set_k.add(x)

    for i in drives:
        for j in set_k:
            if i + j <= b and i + j >= global_max:
                global_max = i + j

    return global_max
