# Unary and Bitwise Operators

# Unary operator: only has a right-side operand (in contrast, the + operator takes 2 operands)
# Bitwise operator: makes use of bits in a Truth Table

# Print int from binary
one     = 0b01
two     = 0b10
three   = 0b11
print(one)
print(two)
print(three)
print('---\n')

# Get the binary
print(bin(one))
print(bin(two))
print(bin(three))
print('---\n')

# Bitwise Complement (rarely used...)
a = 0b10
print(a)        # returns  2
print(~a)       # returns -3  (makes the number negative, and moves one to the left)
                #   or use this formula: -1 * a - 1   = -3 (in this case)
print(bin(~a))  # returns -0b11
print('---\n')

# Bitwise (Truth Table, includes OR, AND, XOR and NOT)

# Bitwise: OR
# Note: 1 means true
a = 0b1001 # returns 9
b = 0b1100 # return 12
#   0b1101 # 1 or 0 = 1 (only one them must be true, to return true, however, note that 1 or 1 = 1)
c = a | b
print(c) # returns 13
print('---\n')

a = 0b0101 # returns 5
b = 0b0100 # returns 4
#   0b0101  # 1 or 0 = 1 (only one them must be true, to return true, however, note that 1 or 1 = 1)
print(bin(a))   # 5
print(bin(b))   # 4
c = a | b       # 5
print(bin(c))
print('---\n')