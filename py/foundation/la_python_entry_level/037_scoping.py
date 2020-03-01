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

# Visibility of x in this conditional is 'public'
if 1 < 2:
    x = 5

# Visibility of x in this loop is 'public'
while x < 6:
    print(x)
    x += 1

print(x)
print()

# -----------------------------------------------------------------------------
# Hiding (shadowing)
# -----------------------------------------------------------------------------
y = 5

def set_x(y):
    print(f'Inner y: {y}')
    x = y
    y = x

set_x(10)
print(f'Outer y: {y}')