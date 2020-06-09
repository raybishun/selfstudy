# =============================================================================
# Collections: Lists
# =============================================================================
my_list = [1, 2, 3, 'four', 5.5, True]
print(my_list)
print(my_list[2])
print(len(my_list))
print(my_list[0:3])
print(my_list[0:])
print(my_list[:3])
print(my_list[0::2]) # step by n
print()

# Lists are mutable
my_list[0] = 'one'
my_list += [7, 8, 9]
my_list[0:3] = ['a', 'b', 'c', 'd', 'e', 'f']
print(my_list)
print()
my_list[6:] = []
print(my_list)
print()

del my_list[0]
print(my_list)