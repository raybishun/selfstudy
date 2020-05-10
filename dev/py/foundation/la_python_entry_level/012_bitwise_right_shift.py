# =============================================================================
# Bitwise Right-Shift
# =============================================================================
a = 0b110 # 6
print(f'{bin(a)}')  # returns --> 0b110

# Right-Shit actually means MOVE LEFT
print(f'{bin(a >> 2 )}')    # returns --> 0b1

# And if you move too far and a 0 is returned
print(f'{bin(a >> 5 )}')    # returns --> 0b0