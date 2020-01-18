# =============================================================================
# isinstance
# =============================================================================
x = (1, 2, 3, 4, 5) # note the ()
y = [1, 2, 3, 4, 5] # note the []

# Check x
if isinstance(x, tuple):
    print(f'x is of type {type(x)}, and is indeed a tuple.')
elif isinstance(x, list):
    print(f'x is of type {type(x)}, and is indeed a list.')
else:
    print('Unknown')

# Check y
if isinstance(y, tuple):
    print(f'y is of type {type(y)}, and is indeed a tuple.')
elif isinstance(y, list):
    print(f'y is of type {type(y)}, and is indeed a list.')
else:
    print('Unknown')