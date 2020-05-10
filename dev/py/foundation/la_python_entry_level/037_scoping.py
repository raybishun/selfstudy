# =============================================================================
# Scoping
# =============================================================================
"""
    Functions set their own scope.
    
    However, conditionals and loops DO NOT define their own scopes.
"""
# Visibility of x in this function is 'private'
def set_x():
    x = 1

set_x()

# -----------------------------------------------------------------------------
# Visibility of x in this conditional is 'public'
if 1 < 2:
    x = 5

# Visibility of x in this loop is 'public'
while x < 6:
    print(x) # returns --> 5
    x += 1

print(x)  # returns --> 6
print()
# -----------------------------------------------------------------------------


# -----------------------------------------------------------------------------
# Another example of scope
# -----------------------------------------------------------------------------
y = 5

def set_x(y):
    print(f'Inside function y is: {y}') # returns --> 10
    x = y
    print(f'Inside function x is: {x}') # returns --> 10
    y = x
    print(f'Inside function y is: {y}') # returns --> 10

set_x(10)
print(f'Outside function y is: {y}') # returns --> 5