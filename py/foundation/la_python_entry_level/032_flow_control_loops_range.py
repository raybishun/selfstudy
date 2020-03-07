# =============================================================================
# Flow Control: Loops: Range
# =============================================================================
"""
    Range is an immutable sequence type.

    Can have a Start, Stop, Stride

    Tip: Very efficient in memory, because only calculated when needed
"""

# Range with a tuple
my_range = range(10)
print(my_range)
# returns --> range(0, 10)

# Convert to a list
print(list(my_range))
# returns --> [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

# Note the '_' means don't need/care about the variable
for _ in range(10):
    print('just do something 10 times ...')