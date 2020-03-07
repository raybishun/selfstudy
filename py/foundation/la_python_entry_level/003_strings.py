# =============================================================================
# Strings
# =============================================================================
# A string is a collection of tokens

# Multiline string
"""
    This is a multiline string
    It is NOT a comment block
    As such, this is not a 'free' item
    Python does NOT have block comments
"""
# Misc
a = 'this is a string'
b = "this is a string"
c = '\'this is a string\''
d = "\"this is a string\""
e = '\\this is a string\\'
f = 'hello' + ' world'
g = "ha " * 4
print(f'{a}\n{b}\n{c}\n{d}\n{e}')
print(f)
print(g)
print()

# Return index (note, first item is 0)
print("hello world".find('e'))  # return 1
print("hello world".find('ll')) # returns 2
print("hello world".find('hi')) # returns -1 if not found
print('Hello World'.lower())    # returns hello world