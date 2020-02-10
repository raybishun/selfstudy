# =============================================================================
#  000_datatypes_evaluations_io_operations
# =============================================================================

# Unary and Bitwise Operators

# Bitwise Complement 
print(~1) # -1 minus one
print(~2) # -1 one minus one

a = 0b010 # note, a is 2
print(a)
print(bin(a))
print(~a)

print()

# OR
a = 0b1001
b = 0b1100
print(bin(a))
print(bin(b))
print(bin(a | b))

# AND