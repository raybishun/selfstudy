# =============================================================================
# Bitwise AND Operator
# =============================================================================
a = 0b1001  # 9
b = 0b1100  # 12

print(f'{bin(a)}')      # returns --> 0b1001
print(f'{bin(b)}')      # returns --> 0b1100

# Both operands must be True
print(f'{bin(a & b)}')  # returns --> 0b1000

# Decimal
print(f'{(a & b)}')     # returns --> 8