# =============================================================================
# Bitwise Left Shift
# =============================================================================
a = 0b110
print(f'{bin(a)}')

# Push to the left by two
# Said differently, move a (fake) decimal, 2 places to the right
# You're simply padding zeros
print(f'{bin(a << 2 )}')