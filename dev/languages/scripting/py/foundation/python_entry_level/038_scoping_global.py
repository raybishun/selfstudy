# =============================================================================
# Scoping: Global
# =============================================================================
y = 5

def set_x(value):
    x = value
    global y
    global a
    y = x
    a = 7

print(f'y before set_x: {y}')   # returns --> 5

set_x(10)

print(f'y after set_x: {y}')    # returns --> 10

print(f'a after set_x: {a}')    # returns --> 7