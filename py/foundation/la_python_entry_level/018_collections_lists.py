# =============================================================================
# Collections: Lists
# =============================================================================
"""
    lists are mutable

    Tip: []
"""
my_list = [0, 'a', 'b', 'c']
my_list[0] = 999

# Adding items to a list via += will actually create a new list
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
# returns --> ['a', 'b', 'c', 'apple', 1, 2, 3, 4]

# Searching: return index (location) where value found
print(my_list.index('apple'))
# returns --> 3

# Searching: return True/False
print('apple' in my_list) # returns --> True
print('apple' not in my_list) # returns --> False

# Sorting: must contain same type, i.e. cannot be alphanumeric
my_list = [5, 1, 3, 2, 4]
print(sorted(my_list))

# Sorting: reversing a list
print(my_list)
print( list(reversed(my_list)) )

# Sorting: sort, reverse, then return as list
print(list(reversed(sorted(my_list))))

# Unpacking lists into variables
v, w, x, y, z = my_list
print(x) # returns 3