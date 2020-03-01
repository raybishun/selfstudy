# =============================================================================
# Functions: Recursion
# =============================================================================
def fib(n):
    # Calculate the value of a particular fib position
    if n == 0:
        return 0
    elif n == 1:
        return 1
    
    return fib(n - 2) + fib(n - 1)

print(fib(13)) # Returns 233