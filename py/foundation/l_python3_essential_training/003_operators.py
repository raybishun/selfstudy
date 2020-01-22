# =============================================================================
# Operators
# =============================================================================

# -----------------------------------------------------------------------------
# Arithmetic Operators
# -----------------------------------------------------------------------------
"""
    +   Addition
    -   Subtraction
    *   Multiplication
    /   Division
    //  Integer Division
    %   Modulo (remainder)
    **  Exponent
    -   Unary negative 
    +   Unary positive 

    NOTE: Unary does not actually change the value of the operand.
          It seems to be their for descriptive purposes.
"""

# Division (retuns a float)
x = 5
y = 3
z = x / y
print(f'{type(z)}, {z}')
print()

# Division - return integer
x = 5
y = 3
z = x // y
print(f'{type(z)}, {z}')
print()

# Division - return remainder (aka modulo) as an integer
x = 5
y = 3
z = x % y
print(f'{type(z)}, {z}')
print()

# Unary (negative)
x = 5
y = 3
z = x + y
z = -z
print(f'{type(z)}, {z}')
print()

# Unary (positive)
x = 5
y = 3
z = x + y
z = +z
print(f'{type(z)}, {z}')
print()

# -----------------------------------------------------------------------------
# Bitwise Operators
# -----------------------------------------------------------------------------
"""
    &   And
    |   Or
    ^   Xor
    <<  Shift left
    >>  Shift right
"""

# Assign two hexadecimal integer literals
x = 0x0a
y = 0x02
z = x & y

# Print as hex
#   Note, the format specifiers are set to return
#   a 2 character string, 
#   with a leading zero,
#   and 'x' denoting hex
print(f'x is {x:02x}')
print(f'y is {y:02x}')
print(f'z is {z:02x}')
print()

# Print as binary
#   Note, the format specifiers are set to return
#   an 8 character string, 
#   with a leading zero,
#   and 'b' denoting binary
print(f'x is {x:08b}')
print(f'y is {y:08b}')
print(f'z is {z:08b}')
print()

# Note about the binary results when using the '&' operator:
#   '&' will only set bits if both operands have bits set 
#   in the same position.
#   This is why 00001010 & 00000010 = 00000010

# -----------------------------------------------------------------------------
# Comparison Operators
# -----------------------------------------------------------------------------
"""
    <
    >
    <=
    >=
    ==  Checks if values are the same
    !=
"""

# Check if values are the same
x = 1
y = 2
if x == y:
    print('Same')
else:
    print('Different')

# -----------------------------------------------------------------------------
# Boolean Operators
# -----------------------------------------------------------------------------
"""
    and     Both operands must be True
    or      At least one operand must be True
    not     'Unary Not'
    in      Value in collection
    not in  Value not in collection
    is      Same object ID
    is not  Different object ID
"""

# 'and' - both operands must be true
t = True
f = False
if t and f:
    print('True')
else:
    print('False')

# 'in' - check if value exists in collection
listNums = [1, 2, 3, 4, 5]
if 33 in listNums:
    print('True')
else:
    print('False')


# -----------------------------------------------------------------------------
# Operator Precedence
# -----------------------------------------------------------------------------
"""
    **              Exponent
    +x, -x          Positive, Negative
    *, /, //, %     Multiplication, Division, Remainder
    +, -            Addition, Subtraction
    <<, >>          Bitwise Shifts
    &               Bitwise AND
    ^               Bitwise XOR
    |               Bitwise OR
    in, not in, is, is not, <, <=, >, >=, !=, ==
                    Comparison, including membership tests and ID tests
    not x           Boolean NOT
    and             Boolean AND
    or              Boolean OR
"""