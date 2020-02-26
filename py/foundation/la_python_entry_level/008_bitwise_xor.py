# =============================================================================
# Bitwise XOR (Exclusive OR) Operator
# =============================================================================
a = 0b1001
b = 0b1100

print(f'{bin(a)}')
print(f'{bin(b)}')

# Looks for only when the two numbers are NOT the same
# So a 1 and 1 = 0 (false)
# But a 1 and 0 = 1 (true)
# And a 0 and 1 = 1 (true)
print(f'{bin(a ^ b)}')

# Decimal
print(f'{(a ^ b)}')