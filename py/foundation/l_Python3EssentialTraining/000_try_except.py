# =============================================================================
# Exception Handling
# =============================================================================
import sys

# Given a Tuple
x = (1, 2, 3, 4, 5)

try:
    # Attempt to change an item
    x[1] = 22
except:
    print(f'{sys.exc_info()[0]}, {sys.exc_info()[1]}')

for i in x:
    print(f'i = {i}')