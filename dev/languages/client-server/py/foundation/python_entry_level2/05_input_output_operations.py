# Typecasting
# =============================================================================
print(float(1))  # 1.0

print(int(1.618)) # 1

print(str(1.618)) # 'a string value of '1.618'

print(str(True)) # 'True'

print(int('5')) # 5 as an int

# Doesn't truncate the decimal portion, actually returns: 
# Exception has occurred: ValueError: invalid literal for int() with base 10: '1.618'
# print(int('1.618')) 

# Interesting 'bool' behavior:
#   practically everything returns true,
#   except for anything that returns 0 or that is 0 length
print(bool(1)) # true
print(bool(1.618)) # true
print(bool('abc')) # true
print(bool(0)) # false
print(bool('')) # false

print(1 and 0) # 0
print(1 or 0) # 1

# Input Function
# =============================================================================
name = input("Enter name: ")
number = int(input("Enter your luck number: "))

# Print Function
# =============================================================================
print('Really, ' + 'your lucky number is ' + str(number))
print('Hello', name, 'would you like to play a game?')

# end=' '
print('Do', end=' ')
print('not', end=' ')
print('include', end=' ')
print('crlf')

# sep=' ' (' ' is the default separator)
print('a', 'b', 'c', sep='-')