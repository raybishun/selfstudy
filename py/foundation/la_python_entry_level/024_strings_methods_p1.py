# =============================================================================
# Strings: Methods Part 1
# =============================================================================
my_str = 'tEsTinG rOboT'
print(my_str.lower())
print(my_str.upper())
print(my_str.capitalize())
print(my_str.title())

print(my_str.isascii())
print(my_str.islower())
print(my_str.isupper())
print(my_str.istitle())
print()

# Is this written in decimal notation?
# (not that it is a decimal)
print("1.0".isdecimal())
print("1".isdecimal())
print()

print("1".isdigit())
print("1.0".isnumeric())

# Check for space
print(' '.isspace())
print(" ".isspace())

print("1a".isalpha())
print("asdf".isalpha())

# Is alpha numeric?
print("1a".isalnum())

# Check if can be an identifier, i.e. name of a variable, function, etc.
print("1wtf".isidentifier())

# Escape characters in the string will cause isprintable() to return false
print("am I printable\n".isprintable())