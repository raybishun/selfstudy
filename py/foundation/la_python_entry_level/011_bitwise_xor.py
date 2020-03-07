# =============================================================================
# Bitwise XOR (Exclusive OR) Operator
# =============================================================================
a = 0b1001  # 9
b = 0b1100  # 12

print(f'{bin(a)}')      # returns --> 0b1001
print(f'{bin(b)}')      # returns --> 0b1100

# The bits must be different
# So    1 and 1 = 0 (false)
#       1 and 0 = 1 (true)
#       0 and 1 = 1 (true)
print(f'{bin(a ^ b)}')  # return -->  0b101

# Decimal
print(f'{(a ^ b)}')     # returns --> 5