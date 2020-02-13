# =============================================================================
# Collections: Lists - Methods
# =============================================================================
my_list = [1, 3, 4, 8, 2]
my_list.append(4)
my_list.insert(0, 'a')

# what is at the first index?
print(my_list.index(1))

# does 4 exist in list?
print(4 in my_list)

# 5 not in list?
print(5 not in my_list)

print(my_list)
print()

# Return a 'new' list of sorted items
my_list = [1, 3, 4, 8, 2]
print(sorted(my_list))
print()

print(reversed(my_list))
print(list(reversed(my_list)))
print(list(reversed(sorted(my_list))))