# Clear
#print('\x1b[2J')

# =============================================================================
# Types
# =============================================================================
x = 1.618
print(f'{x}')
print(type(x))

# =============================================================================
# String ('abc' same as "abc" in Python)
# =============================================================================
x = 'one'.capitalize()
y = 'two'.upper()
print(f'{x}')
print(type(x), type(y))

z = 'switched and 0s added "{1:<09}" "{0:>09}"'.format("zero", 'one')
print('z {}'.format(z))

# =============================================================================
# Numeric types (integers and floats)
# =============================================================================
print('\x1b[2J')

x = 7 / 3
print(f'{x}')
print(type(x))

x = 7 // 3 # // returns only the int
print(f'{x}')
print(type(x))

x = 7 % 3 # // modulo (the %) returns remainder
print(f'{x}')
print(type(x))

# float NOT for use with money !!!
# below example shows why, and it's due to accuracy vs precision
# where decimal returns accuracy (for use with money)
# but float return floating point accuracy
x = .10 + .10 + .10 - .30
print(f'{x}')
print(type(x))

# =============================================================================
# Decimal
# =============================================================================
from decimal import *
a = Decimal('.10')
b = Decimal('.30')
x = a + a + a - b
print(f'{x}')
print(type(x))

# =============================================================================
# 
# =============================================================================

# =============================================================================
# 
# =============================================================================