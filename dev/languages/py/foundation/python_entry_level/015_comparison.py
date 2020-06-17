# =============================================================================
# Comparison Operators
# =============================================================================
"""
    <       less than
    >       greater than
    <=      less than or equal
    >=      greater than or equal
    ==      is equal
    !=      not equal
    is      identity operator (checks if same TYPE)
    is not  checks for opposite TYPES
"""

# Ord function
print(ord('a'), ord('A')) # 97 65
print(ord('b'), ord('B')) # 98 66
print(ord('c'), ord('C')) # 99 67
print()

# id
print(1 is '1') # False
print(id(1))    # 140734911858336
print(id('1'))  # 2191559894000