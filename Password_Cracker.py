sys.setrecursionlimit(200000)

memo = {}

def process(passwords, loginAttempt):
    global memo
    # print("loginAttempt = {} memo = {}".format(loginAttempt, memo))
    if len(loginAttempt) == 0:
        return True, []
    
    if loginAttempt in memo:
        return False, []
    
    for password in passwords:
        if loginAttempt.startswith(password):
            memo[loginAttempt] = True
            
            sol, result = process(passwords, loginAttempt[len(password):])
            if sol == True:
                return True, [password] + result
            
    return False, []

def passwordCracker(passwords, loginAttempt):
    global memo
    memo = {}
    sol, result = process(passwords, loginAttempt)

    if sol:
        return ' '.join(result)
    
    return "WRONG PASSWORD"
