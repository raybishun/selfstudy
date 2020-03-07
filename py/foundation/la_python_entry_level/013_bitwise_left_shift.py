# =============================================================================
# Bitwise Left-Shift
# =============================================================================
a = 0b110 # 6
print(f'{bin(a)}') # --> returns 0b110

# Left-Shit actually means MOVE RIGHT 
# (you're simply padding zeros)
print(f'{bin(a << 2 )}') # returns --> 0b11000