# =============================================================================
# Number Systems & Conversion
# =============================================================================

# Decimal: Base 10 (0 - 9)
a = 15
print(f'{a}')
# returns --> 15

# Binary: Base 2 (0 - 1)
# Prefix: 0b
print(f'{bin(a)}')
# returns --> 0b1111

print(f'{0b1111}')
# returns --> 15

# Octal: Base 8 (0 - 7)
# Prefix: 0o
print(f'{0o7242}')
# returns --> 3746

# Hexadecimal: Base 16 (0 - 9, A - F)
# Prefix: 0x
print(f'{0xFF012}')
# returns --> 1044498

# -----------------------------------------------------------------------------
# Converting Decimal to Binary 
# -----------------------------------------------------------------------------
"""
    Decimal: 15
    
    Solution: Simply divide by the base you are converting to
              i.e binary (base2) in this example

    15 / 2 = 7 w/remainder of 1 (Least significant - the ones column)
     7 / 2 = 3 w/remainder of 1
     3 / 2 = 1 w/remainder of 1
     1 / 2 = 0 w/remainder of 1 (Most significant - the thousands column)
                                (Most significant is the highest number)
    Result: 1111
"""
# -----------------------------------------------------------------------------
# Converting back from Binary to Decimal
# -----------------------------------------------------------------------------
"""
    Binary: 1111
           (8421)    

    (Most significant                      Least Significant)
    (1  *  2**3) + (1  *  2**2) + (1  *  2**1) + (1  *  2**0)
        1 * 8    +     1 * 4    +     1 * 2    +     1 * 1
          8      +       4      +       2      +       1
    
    Result: 15

    Note: Any number to the power of 0 = 1
"""