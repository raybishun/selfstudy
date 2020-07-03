# =============================================================================
# Unary and Bitwise Operators
# =============================================================================
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

# =============================================================================
# Bitwise (Truth Table, includes OR, AND, XOR and NOT)
# =============================================================================

# -----------------------------------------------------------------------------
# Bitwise: OR (one or the other must be true)
# -----------------------------------------------------------------------------
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

# -----------------------------------------------------------------------------
# Bitwise: AND (both must be true)
# -----------------------------------------------------------------------------
a = 0b0101 # returns 5
b = 0b0100 # returns 4
#   0b0100
print(bin(a))   # 5
print(bin(b))   # 4
c = a & b       # 4
print(bin(c))
print('---\n')

# -----------------------------------------------------------------------------
# Bitwise: XOR (aka Exclusive OR) 
#   requires 1, and only 1 to be true
#   note: 1 and 1 = 0
#   also: 0 and 0 = 0
# -----------------------------------------------------------------------------
a = 0b0101 # returns 5
b = 0b0100 # returns 4
#   0b0001
print(bin(a))   # 5
print(bin(b))   # 4
c = a ^ b       # 1
print(bin(c))
print('---\n')

# -----------------------------------------------------------------------------
# Shift Operators: Right-Shift ( >> )
# -----------------------------------------------------------------------------
# The 'Right' Shift Operator
# For the example below, shift 2 places to the right
a = 0b0110 # returns 6
print(bin(a))
print(bin(a >> 2))
print(bin(a >> 4)) # leading 0 if you attempt to shift too far (returns 0b0)
print('---\n')

# -----------------------------------------------------------------------------
# Shift Operators: Left-Shift ( << )
# -----------------------------------------------------------------------------
# The 'Left' Shift Operator
# For the example below, shift 2 places to the left
# And of course, the number grows (as you're adding 0s to the end)
a = 0b0110 # returns 6
print(bin(a))       # 0b110
print(bin(a << 2))  # 0b11000 (or 24)
print('---\n')

# -----------------------------------------------------------------------------
# Boolean
# -----------------------------------------------------------------------------
# unary operator
print(not True)         # False
print(not False)        # True
print('---\n')

# 'or' - one must be true
print(True or True)     # True
print(True or False)    # True
print(False or False)   # False
print(False or True)    # True
print('---\n')

# 'and' - both must be true
print(True and True)     # True
print(True and False)    # False
print(False and False)   # False
print(False and True)    # False
print('---\n')

# -----------------------------------------------------------------------------
# Comparison Operators
# -----------------------------------------------------------------------------
print('bb' > 'ab') # True
print('---\n')

# -----------------------------------------------------------------------------
# ord Function
# -----------------------------------------------------------------------------
print(ord('a')) # 97
print(ord('b')) # 98
print(ord('c')) # 99
print('---\n')

# -----------------------------------------------------------------------------
# is equal to...
# -----------------------------------------------------------------------------
x = 1.0
print(1 == x) # True
print('---\n')

# -----------------------------------------------------------------------------
# is the same object
# -----------------------------------------------------------------------------
x = 1.0
y = 1
print(x is y) # False
print(y is 1.0) # False
print('---\n')

# -----------------------------------------------------------------------------
# is the same object
# -----------------------------------------------------------------------------
x = 1
y = 3
print(x is not y) # True
print('---\n')

# -----------------------------------------------------------------------------
# Get an object's ID
# -----------------------------------------------------------------------------
# note, w and x point to the 'same' memory location 
# (because 1 is only stored once in memory, and is immutable)
w = 1 
x= 1 
y= 1.0
z = 2
print(id(w))
print(id(x))
print(id(y))
print(id(z))
print('---\n')

# -----------------------------------------------------------------------------
# Example of a mutable type
# -----------------------------------------------------------------------------
# lists
# [] is an empty list
print([] is []) # false - why? because you can 'modify' a list, it's mutable

# -----------------------------------------------------------------------------
# Operator Priority (Binding)
# -----------------------------------------------------------------------------
# Parenthesis and List/Dictionary/Set literals
# Accessing attributes (subscription, slicing, function/method call, attribute reference)
# Exponentiation (**)
# Positive, Negative, and bitwise complement
# Multiplication *, Division /, Floor Division //, Modulo %
# Addition +, Subtraction -
# Bitwise Shifts << & >>
# Bitwise AND &
# Bitwise XOR ^
# Bitwise OR |
# Comparison operators (in, not in, is, is not, <, >, <=, >=, ==, !=)
# Boolean NOT not
# Boolean AND and
# Boolean OR or
# Conditions if