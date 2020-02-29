# =============================================================================
# Collections: Lists
# =============================================================================
"""
    lists are mutable
"""
my_list = [0, 'a', 'b', 'c']
my_list[0] = 999

# Adding items to a list via += will actually create another list
my_list += [1, 2, 3]
print(my_list)

# Using the 'del' keyword
del my_list[0]
print(my_list)

# Append to list
my_list.append(4)
print(my_list)

# Insert after the 3rd item
my_list.insert(3, "apple")
print(my_list)

# Searching: return index (location) where value found
print(my_list.index('apple'))

# Searching: return True/False
print('apple' in my_list)
print('apple' not in my_list)

# Sorting: must contain same type, i.e. cannot be alphanumeric
my_list = [5, 1, 3, 2, 4]
print(sorted(my_list))

# Sorting: reversing a list
print(my_list)
print( list(reversed(my_list)) )

# Sorting: sort, reverse, then return as list
print(list(reversed(sorted(my_list))))