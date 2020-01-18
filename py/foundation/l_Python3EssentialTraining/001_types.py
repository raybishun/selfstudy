

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