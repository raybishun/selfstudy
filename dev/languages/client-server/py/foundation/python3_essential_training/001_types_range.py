# =============================================================================
# Range
# =============================================================================
import sys

# -----------------------------------------------------------------------------
# Print 0 thru 4 (using end-of-range, the 5)
# -----------------------------------------------------------------------------
x = range(5)
try:
    # Range is immutable
    x[1] = 11
except:
    print(f'{sys.exc_info()[0]}, {sys.exc_info()[1]}')

for i in x:
    print(f'i = {i}')
print()

# -----------------------------------------------------------------------------
# Print 5 thru 9 (Start and End provided)
# -----------------------------------------------------------------------------
x = range(5, 10)
for i in x:
    print(f'i = {i}')
print()

# -----------------------------------------------------------------------------
# Print 0 thru 8 (Start, End and Step provided)
# -----------------------------------------------------------------------------
x = range(0, 10, 2)
for i in x:
    print(f'i = {i}')
print()

# -----------------------------------------------------------------------------
# Range can be mutable, i.e. if enclosed within a list
# -----------------------------------------------------------------------------
x = list(range(5))
x[1] = 11
for i in x:
    print(f'i = {i}')