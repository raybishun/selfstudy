# =============================================================================
# Print()
# =============================================================================
"""
    print() automatically adds a crlf at the eol
"""

first_name = input("Enter First Name: ")
last_name = input("Enter Last Name: ")

# Both on same line (note: uses the default sep=" " for spacing)
# print(first_name, last_name)

# print(first_name)   # prints on new line
# print(last_name)    # prints on new line

# Both on same line (using end=" ")
print(first_name, end=" ")
print(last_name)
# results --> Peter Parker

# If not specified in a print statement, sep=" " is used by default
# Here I'm using a comma to separate the two string tokens
print(last_name, first_name, sep=", ")
# results --> Parker, Peter