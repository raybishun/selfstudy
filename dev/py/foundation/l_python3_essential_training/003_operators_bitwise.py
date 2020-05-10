# =============================================================================
# Bitwise Operators
# =============================================================================
"""
    Bitwise operators are used to work with numbers,
    specifically, the underlying ints and uints bits.

    Bitwise operators include:
    
    &   And
    |   Or
    ^   Xor (exclusive Or)
    <<  Shift left
    >>  Shift right
"""

# Assign two hexadecimal integer literals
x = 0x0a
y = 0x02
z = x & y

# Print as hex
#   Note, the format specifiers are set to return
#   a 2 character string, 
#   with a leading zero,
#   and 'x' denotes hex
print(f'x is {x:02x}')
print(f'y is {y:02x}')
print(f'z is {z:02x}')
print()

# Print as binary
#   Note, the format specifiers are set to return
#   an 8 character string, 
#   with a leading zero,
#   and 'b' denotes binary
print(f'x is {x:08b}')
print(f'y is {y:08b}')
print(f'z is {z:08b}')
print()

# -----------------------------------------------------------------------------
# And
# -----------------------------------------------------------------------------
print('\x1b[2J')

x = 0x0a
y = 0x02

def display_x_and_y():
    print(f'{x:02x}\t{x:08b}\t{x:02d}')
    print(f'{y:02x}\t{y:08b}\t{y:02d}')

z = x & y
display_x_and_y()
print('& (And) ------------------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # set only when both bits are set
print()
print()

# -----------------------------------------------------------------------------
# Or 
# -----------------------------------------------------------------------------
z = x | y
display_x_and_y()
print('| (Or) -------------------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # set if one of the bits are set
print()
print()

# -----------------------------------------------------------------------------
# Xor (exclusive Or) 
# -----------------------------------------------------------------------------
z = x ^ y
display_x_and_y()
print('^ (Xor) ------------------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # set when only one bit is set
print()
print()

# -----------------------------------------------------------------------------
# <<  Shift left
# -----------------------------------------------------------------------------
y = 0x03
z = x << y
display_x_and_y()
print('<< (Shift Left) ----------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # shift x 3 to the left
print()
print()

# -----------------------------------------------------------------------------
# <<  Shift left (example 2)
# -----------------------------------------------------------------------------
y = 0x05
z = x << y
display_x_and_y()
print('<< (Shift Left) ----------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # shift x 5 to the left
print()
print()

# -----------------------------------------------------------------------------
# <<  Shift Right
# -----------------------------------------------------------------------------
y = 0x02
z = x >> y
display_x_and_y()
print('>> (Shift Right) ---------------')
print(f'{z:02x}\t{z:08b}\t{z:02d}') # shift x 2 to the right