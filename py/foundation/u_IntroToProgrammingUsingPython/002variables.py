name = "Ray Bishun"
ctr = 100

print("ctr is ", ctr)

a = b = c = ctr
print(a, b, c, ctr)

a, b, c = ctr, ctr, name
print(a, b, c)

# =============================================================================
# Python Datatypes
# =============================================================================
# 1. Numbers (int, float, complex)
# 2. String
# 3. List
# 4. Tuple
# 5. Dictionary

# =============================================================================
# Numbers
# =============================================================================
var1 = 2000
print(var1)
del var1
# print(var1);

# =============================================================================
# Strings
# =============================================================================
name = "Ray Bishun"
greeting = "Hello, "
print(name[0])
print(name[4:10])
print(greeting + name)
print(greeting * 3, name)

# =============================================================================
# Lists
# =============================================================================
list = ['Hello World', 150, 1.25, "Ray Bishun", 100.25]
tinyList = [300, 'Ray']

print(list)
print(tinyList * 2)
print(tinyList[1])

nums = ["one", "two", "three", "four", "five"]
print(nums[2:3])

# =============================================================================
# Tuples (think of tuples as read-only lists)
# =============================================================================
sample_tuple = ('Hello Ray', 1.618, .618, 'Hello again', 133)
print(sample_tuple[1])
# sample_tuple[0] = 'hi'; # TypeError: 'tuple' object does NOT support item assignment

# =============================================================================
# Dictionary
# =============================================================================
print("---------------------------")
dictionary = {}
dictionary['one'] = "first element"
dictionary[2] = "second element"

tiny_dictionary = {'name': 'Ray', 'age': '25', 'id': '618', 'role': 'developer'}
print(dictionary['one'])
print(tiny_dictionary['id'])
print(tiny_dictionary.keys())
print(tiny_dictionary.values())

# =============================================================================
# DataType Conversion
# =============================================================================
print(int('20')+10)
print(float('1.618'))

# =============================================================================
# Variable Operators
# =============================================================================
#   % = remainder

# =============================================================================
# Conditional Operators
# =============================================================================
# x && y 
# x || y