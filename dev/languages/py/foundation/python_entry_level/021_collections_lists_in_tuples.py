# =============================================================================
# Collections: Lists within Tuples
# =============================================================================
"""
    Are you able to change a mutable type that is contained within a tuple? - Yes
    Because the size of the tuple, (or what it is pointing to) doesn't actually change
"""
my_list = [1, 2 ,3]
print(my_list) # returns --> [1, 2, 3]
print();

my_tuple_containing_a_list = (my_list, 1)
print(my_tuple_containing_a_list) # returns --> ([1, 2, 3], 1)
print()

my_list_containing_a_tuple = [1, 2, my_tuple_containing_a_list]
print(my_list_containing_a_tuple) # returns --> [1, 2, ([1, 2, 3], 1)]
print()

my_list.append(4)
print(my_list_containing_a_tuple) # returns --> [1, 2, ([1, 2, 3, 4], 1)]