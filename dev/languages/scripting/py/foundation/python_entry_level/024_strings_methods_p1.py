# =============================================================================
# Strings: Methods Part 1
# =============================================================================
my_str = 'tEsTinG rOboT'
print(my_str.lower())
print(my_str.upper())
print(my_str.capitalize())  # returns --> Testing robot
print(my_str.title())       # returns --> Testing Robot

print(my_str.isascii()) # returns --> True
print(my_str.islower()) # returns --> False
print(my_str.isupper()) # returns --> False
print(my_str.istitle()) # returns --> False
print()

# Is this written in decimal notation?
# (not that it is a decimal)
print("1.0".isdecimal())    # returns --> False
print("1".isdecimal())      # returns --> True
print()

print("1".isdigit())        # returns --> True
print("1.0".isnumeric())    # returns --> False

# Check for space
print(' '.isspace())    # returns --> True
print(" ".isspace())    # returns --> True

print("1a".isalpha())   # returns --> False
print("asdf".isalpha()) # returns --> True

# Is alpha numeric?
print("1a".isalnum())   # returns --> True

# Check if can be an identifier, i.e. name of a variable, function, etc.
print("1wtf".isidentifier())    # returns --> False

# Escape characters in the string will cause isprintable() to return false
print("am I printable\n".isprintable()) # returns --> False