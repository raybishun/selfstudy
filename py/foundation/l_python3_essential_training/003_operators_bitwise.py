# =============================================================================
# Bitwise Operators
# =============================================================================
"""
    &   And
    |   Or
    ^   Xor
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
#   and 'x' denoting hex
print(f'x is {x:02x}')
print(f'y is {y:02x}')
print(f'z is {z:02x}')
print()

# Print as binary
#   Note, the format specifiers are set to return
#   an 8 character string, 
#   with a leading zero,
#   and 'b' denoting binary
print(f'x is {x:08b}')
print(f'y is {y:08b}')
print(f'z is {z:08b}')
print()

# Note about the binary results when using the '&' operator:
#   '&' will only set bits if both operands have bits set 
#   in the same position.
#   This is why 00001010 & 00000010 = 00000010