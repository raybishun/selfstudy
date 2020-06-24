# Floor division (how many times 3 divides into 5)
print( 5 // 3 ) # 1
print( 6 // 2 ) # 3

# Modulo (return the remainder)
# Modulo is commonly used to determine if some value is even or odd
print (  5 % 3  ) # 2
print( 6 % 2 ) # 0 (even)
print ( 7 % 2 ) # 1 (odd)

# Exponents ( ** )
print( 2 ** 3 ) # 8 (2 * 2 * 2 = 8), aka 2 to the power of 3

print('---\n')

# Numbering Systems
# Binary      - base  2 (that is, only 2 possible options: 0 or 1)
# Octal       - base  8 (that is, only 8 possible options: 0 - 7)
# Decimal     - base 10 (that is, only 10 possible options: 0 - 9)
# Hexadecimal - base 16 (that is, only 16 possible options: 0 - 9, and A - F)

# Using prefixes to represent the appropriate numbering system
# Binary      - 0b
# Octal       - 0o
# Hexadecimal - 0x

# Converting Decimal to Binary,
# Since Binary is base 2, we divide by 2
# 15 / 2 = 7 with a remainder of 1  (thi is the least significant bit)
#  7 / 2 = 3 with a remainder of 1
#  3 / 2 = 1 with a remainder of 1
#  1 / 2 = 0 with a remainder of 1   (this is the most significant bit)
# done when nothing left to divide
# Binary = 1111

# Converting Binary to Decimal
#  (most significant bit)                  (least significant bit)
#          (1 * 2(3)) + (1 * 2(2)) + (1 * 2(1)) + (1 * 2(0))
#               8     +     4      +     2      +     1
#  Equals 15

# Floating-Point Accuracy (...or not so accurate)
# - Are stored as binary fractions in memory
# - Not all decimal values can be represented as binary fractions, i.e. 0.1
# - As such, floats can introduce rounding issues