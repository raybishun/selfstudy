# =============================================================================
# Function Decorators
# =============================================================================
"""
    Decorators return a 'wrapper function'
    
    ...seems similar to delegates in C#
"""

# -----------------------------------------------------------------------------
# Function Overview #1
# -----------------------------------------------------------------------------
def f1():
    print ('Hello from f1')

# call f1
f1()

# call calls f1
x = f1
x()

print()
# -----------------------------------------------------------------------------
# Function Overview #2
# -----------------------------------------------------------------------------
def f1():
    def f2():
        print('Hello from f2 ')
    return f2
x = f1()
x()

print()
print()
# -----------------------------------------------------------------------------
# ...now the decorator in action...
# -----------------------------------------------------------------------------
def f1(f):
    def f2():
        print('Hello from f2 - BEFORE the function call')
        f()
        print('Hello from f2 - AFTER the function call')
    return f2

@f1 # the decorator
def f3():
    print('Hello from f3')

# because of the above decorator, we don't need the next line
#f3 = f1(f3)
f3()

print()