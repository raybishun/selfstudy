# =============================================================================
# Scoping: Global
# =============================================================================
y = 5

def set_x(z):
    x = z
    global y
    global a
    y = x
    a = 7

print(f'y before set_x: {y}')

set_x(10)

print(f'y after set_x: {y}')

print(f'a after set_x: {a}')