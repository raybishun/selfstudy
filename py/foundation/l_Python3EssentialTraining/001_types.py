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
# Sequence types
# =============================================================================
# lists
x = [1, 2, 3, 4, 5]
x[1] = 22 # lists are mutable
for i in x:
    print(f'i = {i}')

# Tuple
# Are immutable
x = (1, 2, 3, 4, 5)
#x[1] = 22 # lists are mutable
for i in x:
    print(f'i = {i}')
print()

# Ranges
# Are immutable
x = range(5) # where 5 is end
for i in x:
    print(f'i = {i}')
print()

x = range(5, 10) # where 5 is start, and 10 is end
for i in x:
    print(f'i = {i}')
print()

x = range(0, 10, 2) # where 5 is start, 10 is end, and 2 is step
for i in x:
    print(f'i = {i}')
print()

# Range can be mutable - if you enclose in a list
x = list(range(5))
x[1] = 11
for i in x:
    print(f'i = {i}')
print()

# =============================================================================
# type() and id()
# =============================================================================
x = (1, 2, 3, 34, 5)
print(f'{x}')
print(type(x))

x = (1, 'two', 3.0, [4, 'four'], 5)
print(f'{x}')
print(type(x[1]))

# id()
x = (1, 'two', 3.0, [4, 'four'], 5)
y = (1, 'two', 3.0, [4, 'four'], 5)
print(f'{x}')
print(id(x))
print(id(y))

if x is y:
    print('yes')
else:
    print('no')

if x[0] is y[0]:
    print('yes')
else:
    print('no')

# isinstance
if isinstance(x, tuple):
    print('is a tuple')
elif isinstance(x, list):
    print('is a list')
else:
    print('no')