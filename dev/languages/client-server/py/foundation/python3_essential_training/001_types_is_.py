# =============================================================================
# is
# =============================================================================
x = (1, 2, 3, 4, 5)
y = (1, 2, 3, 4, 5)

print(type(x))
print(type(y))

print(id(x))
print(id(y))

# is test
if x is y:
    print('yes')
else:
    print('no')