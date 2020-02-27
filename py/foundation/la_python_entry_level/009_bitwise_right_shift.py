# =============================================================================
# Bitwise Right Shift
# =============================================================================
a = 0b110
print(f'{bin(a)}')

# Push to the right by two
# Said differently, move a (fake) decimal, 2 places to the left
print(f'{bin(a >> 2 )}')

# And if you move too far and a 0 is returned
print(f'{bin(a >> 5 )}')