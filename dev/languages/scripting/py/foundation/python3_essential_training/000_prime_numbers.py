# =============================================================================
# Prime Numbers
# =============================================================================
def isprime(n):
    if n <=1:
        return False
    for x in range(2, n):
        if n % x == 0:
            return False
        else:
            return True

def list_primes():
    for n in range(100):
        if isprime(n):
            print(n, end=' ', flush = True)
    print()
    
# -----------------------------------------------------------------------------
# Call Prime Functions
# -----------------------------------------------------------------------------
mynum = 6
if isprime(mynum):
    print(f'{mynum} is prime')
else:
    print(f'{mynum} is NOT prime')
# -----------------------------------------------------------------------------
list_primes();