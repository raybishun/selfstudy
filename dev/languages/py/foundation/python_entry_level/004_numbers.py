
"""
    integers
    floats
    scientific notation
"""

# Scientific notation
print(f'Exponent to the power of 10: {4.5e9}') # note lower case e
# returns --> Exponent to the power of 10: 4500000000.0

print(f'Exponent to the power of 10: {4.5E9}') # note upper case E
# returns --> Exponent to the power of 10: 4500000000.0

print(f'4.5e9 equals {4.5 * (10 ** 9)}') # where ** is 'power'
# returns --> 4.5e9 equals 4500000000.0

print(f'{4.5e9 == 4.5 * (10 ** 9)}')
# returns --> True