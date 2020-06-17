# =============================================================================
# Bitwise Complement (aka Two's complement)
# =============================================================================
a = 2

print(f'binary: {bin( a )}')
# returns --> binary: 0b10

 # Bitwise Complement (aka Two's complement)
print(f'{ ~a }')
# returns --> -3

# ~a simply takes a negative of your number, minus 1
print(f'{ -a - 1 }')
# returns --> -3

# or said differently
# ~a simply takes minus 1, times your number, minus 1
print(f'{ -1 * a - 1 }')
# returns --> -3

print(f'binary: {bin( ~a )}')
# returns --> binary: -0b11