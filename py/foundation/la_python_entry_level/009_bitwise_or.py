# =============================================================================
# Bitwise OR Operator
# =============================================================================
a = 0b1001  # 9
b = 0b1100  # 12

print(f'{bin(a)}')      # returns --> 0b1001
print(f'{bin(b)}')      # returns --> 0b1100

# One of the two operands must be True
print(f'{bin(a | b)}')  # returns --> 0b1101

# Decimal
print(f'{(a | b)}')     # returns --> 13