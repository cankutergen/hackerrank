def gridSearch(G, P):
    lineChecks = 0
    for i in range(len(G[0])-len(P[0])+1):
        for j in range(len(G)-len(P)+1):
            if G[j][i:i+len(P[0])] == P[0]:
                for x in range(1,len(P)):
                    if G[j+x][i:i+len(P[0])] == P[x]:
                        lineChecks +=1
                        if lineChecks == len(P) - 1:
                            return "YES"
                    else:
                        lineChecks = 0
    return "NO"
