def birthday(s, d, m):
    count = 0
    for i in range(len(s) - m + 1):
        sum = 0
        for j in range(m):
            sum += s[i + j]
            if sum > d:
                break

        if sum == d:
            count += 1

    return count
