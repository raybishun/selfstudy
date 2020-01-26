# =============================================================================
# Functions: Pass By Value
# =============================================================================
print('\x1b[2J')

def calc(x):
    x = 2
    print(f'02: The value of x is {x}, and is stored at {id(x)}.')
    print()

x = 1
print(f'01: The value of x is {x}, and is stored at {id(x)}.')
print()

calc(x)

print(f'03: The value of x is {x}, and is stored at {id(x)}.')

# =============================================================================
# Takeaway: Integers are passed by value
# =============================================================================