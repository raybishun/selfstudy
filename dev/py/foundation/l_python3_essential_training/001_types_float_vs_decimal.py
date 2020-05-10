# =============================================================================
# float vs decimal --> precision vs accuracy
# =============================================================================

# Do NOT use float when calculating money !!!
# Below example shows why.
# Float returns floating point --> precision.
# However, Decimal returns accuracy (for use with money).

x = .10 + .10 + .10 - .30
print(f'{x}')
print(type(x))

from decimal import *
a = Decimal('.10')
b = Decimal('.30')
x = a + a + a - b
print(f'{x}')
print(type(x))