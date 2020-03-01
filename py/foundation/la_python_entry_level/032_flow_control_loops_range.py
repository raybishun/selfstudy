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

# Convert to a list
print(list(my_range))

# Note the '_' means don't need/care about the variable
for _ in range(10):
    print('do something 10 X ...')