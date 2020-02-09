# =============================================================================
#  Numbers (integers, floats and scientific notation)
# =============================================================================

# Is 4.5e9 eq to 4.5 * 10 to the power of 9?
print(4.5e9)
print(4.5e9 == 4.5 * (10 ** 9))

# Division
print(5 / 3)

# Floor Division (does NOT return the remainder)
print(5 // 3)

# Modulo (only returns the remainder as an integer)
print(5 % 3)

# Exponent
print(2 ** 3)
print (2 * 2 * 2)

# =============================================================================
#  Common Number Systems
# =============================================================================
# Decimal       - Base10 (0 - 9)
# Binary        - Base2 (0 -1)
# Octal         - Base8 (0 - 7)
# Hexadecimal   - Base16 (0 - 9 and A - F)

# =============================================================================
#  Representing Number Systems in Python
# =============================================================================
# Binary    - Prefix 0b                         - 0b101 
# Octal     - Prefix 0o (zero and lower case o) - 0o7242
# Hex       - Prefix 0x                         - 0xFF012

# =============================================================================
#  Converting decimal number 15 to binary
# =============================================================================
"""
    15 / 2 = 7 with a remainder of 1 (first remainder is the least significant, the lowest number)
    7 / 2 = 3 with a reminder of 1
    3 / 2 = 1 with a remainder of 1
    1 / 2 = 0 with a remainder of 1 (last remainder is the most significant, the highest number, placed in the 1,000 column)

    1111 is the resulting binary number.
"""

# =============================================================================
#  Converting binary back to decimal
# =============================================================================
"""
    binary: 1111
    equals: (1 * 2**3) + (1 * 2**2) + (1 * 2**1) + (1 * 2**0)
        most significant                       least significant

    equals: 8 + 4 + 2 + 1
    equals: 15
"""

# =============================================================================
# Don't use floats for money, use decimal instead
# =============================================================================
