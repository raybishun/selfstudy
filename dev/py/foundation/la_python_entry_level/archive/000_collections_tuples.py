# =============================================================================
# Collections: Tuples
# =============================================================================
"""
    Tuples are immutable
"""
point = (2.0, 3.0)

# note the ',' which makes this a tuple, 
# and not included in a math operation
point_3d = point + (4.0,)
print(point_3d)
print()

x, y, z = point_3d
print(f'{x}\n{y}\n{z}\n')

# -----------------------------------------------------------------------------
# Putting a list in a tuple
# -----------------------------------------------------------------------------
my_list = [1, 2, 3]
my_tuple = (my_list, 1)
print(my_tuple)
print()

# -----------------------------------------------------------------------------
# Putting a tuple in a list
# -----------------------------------------------------------------------------
other_list = [1, 2, my_tuple]
print(other_list)
print()

# -----------------------------------------------------------------------------
# Modifying a list item that is contained within a tuple
# -----------------------------------------------------------------------------
my_list.append(999)
print(my_tuple)
print(other_list)
print()