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

# Division - return integer
x = 5
y = 3
z = x // y
print(f'{type(z)}, {z}')

# Division - return remainder (aka modulo) as an integer
x = 5
y = 3
z = x % y
print(f'{type(z)}, {z}')

# Unary (negative)
x = 5
y = 3
z = x + y
z = -z
print(f'{type(z)}, {z}')

# Unary (positive)
x = 5
y = 3
z = x + y
z = +z
print(f'{type(z)}, {z}')

# -----------------------------------------------------------------------------
# Bitwise Operators
# -----------------------------------------------------------------------------

# -----------------------------------------------------------------------------
# Comparison Operators
# -----------------------------------------------------------------------------

# -----------------------------------------------------------------------------
# Boolean Operators
# -----------------------------------------------------------------------------

# -----------------------------------------------------------------------------
# per Precedence
# -----------------------------------------------------------------------------