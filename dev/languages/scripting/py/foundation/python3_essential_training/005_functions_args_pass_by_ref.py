# =============================================================================
# Functions: Pass By Reference
# =============================================================================
# print('\x1b[2J')

def calc(x):
    x[0] = 9
    print(f'02: The value of x is {x}, and is stored at {id(x)}.')
    print()
    
x = [1, 2, 3]
print(f'01: The value of x is {x}, and is stored at {id(x)}.')
print()

calc(x)

print(f'03: The value of x is {x}, and is stored at {id(x)}.')

# =============================================================================
# Takeaway: lists are passed by reference
# =============================================================================