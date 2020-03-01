# =============================================================================
# Collections: Dictionaries
# =============================================================================
"""
    Dictionaries are a mutable type
    
    use key-value pairs

    however, the keys are immutable (and are used as the index)

    they are similar to hash tables and associative array

    Tip: {}
"""
# -----------------------------------------------------------------------------
# Three ways to create dictionaries
# -----------------------------------------------------------------------------

# Create a dictionary using {}
my_dict = {'julie': 25, 'jennifer': 35, 'ray': 27}

# Create a dictionary using the dict keyword
# my_dict = dict(julie=25, jennifer=35, ray=27)

# Create a dictionary using tuples
# my_dict = dict([('julie', 25), ('jennifer', 35), ('ray', 27)])

# -----------------------------------------------------------------------------
# Working with dictionaries
# -----------------------------------------------------------------------------
# Add an item (if not found, adds it)
my_dict['kelly'] = 39

# Change an item
my_dict['ray'] = 37

# Get an item
print(my_dict['ray'])

# Del an item
del my_dict['ray']

# Find item a Dictionary
print( 'ray' in my_dict )

print(my_dict)

# Get keys
print(my_dict.keys())

# Get keys as a list
print(list(my_dict.keys()))

# Get values
print(my_dict.values())

# Get as a list of tuples
print(my_dict.items())