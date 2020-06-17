# =============================================================================
# Generators
# =============================================================================
"""
    Generators are functions that behave like iterators.    
"""

def gen_range(stop, start=1, step=1):
    num = start
    while num <= stop:
        yield num
        num += step

gen = gen_range(10)

print(next(gen))
print(next(gen))
print(next(gen))
print()

for num in gen_range(10, step=2):
    print(num)
print()

# -----------------------------------------------------------------------------
# Converting Generators into Lists
# -----------------------------------------------------------------------------
gen = gen_range(10)
print(list(gen))
print()

# -----------------------------------------------------------------------------
# Using Generators with Recursion
# -----------------------------------------------------------------------------
def gen_fib():
    a, b = 0, 1
    while True:
        a, b = b, a + b
        yield a

fib = gen_fib()
print(next(fib))
print(next(fib))
print(next(fib))
print(next(fib))
print(next(fib))
print(next(fib))
print(next(fib))
print(next(fib))

# -----------------------------------------------------------------------------
# Get the 'last' iteration of a specified fib sequence, in less than a second
# -----------------------------------------------------------------------------
fib = gen_fib()
print([next(fib) for _ in range(50)][-1])