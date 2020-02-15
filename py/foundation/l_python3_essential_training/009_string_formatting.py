# =============================================================================
# String: Methods
# =============================================================================
x = 3
y = 5
print('{} {}'.format(x, y))
print('{0} {1}'.format(x, y))
print()

# 5 spaces after
print('{0:<5}'.format(x))

# 5 spaces before
print('{0:>5}'.format(y))

# 5 spaces before with leading zeros
print('{0:>05}'.format(y))

# commas
print('{:,}'.format(1000 * 1000))

# replace
print('{:,}'.format(1000 * 1000).replace(',', '-'))

# fixed decimal places
print('{:.3f}'.format(1000 * 1000))

# hex
i = 42
print('{:x}'.format(i))

# octal
print('{:o}'.format(i))

# binary
print('{:b}'.format(i))

# f-string
print(f'{i:b}')