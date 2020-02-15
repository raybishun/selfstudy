# =============================================================================
# String: Methods
# =============================================================================
print('Hello, World!'.upper())
print('Hello, World!'.lower())
#more aggressive than lower(); removes all case distinctions, even in Unicode
print('\tHello, World!'.casefold())
print('Hello, World!'.capitalize())
print('Hello, World!'.title())
print('Hello, World!'.swapcase())

# strings are immutable
s1 = 'Hello World'
s2 = s1
s3 = s2.upper()
print(s1, id(s1))
print(s2, id(s2))
print(s3, id(s3))