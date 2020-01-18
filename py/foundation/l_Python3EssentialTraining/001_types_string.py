# =============================================================================
# String ('abc' same as "abc" in Python)
# =============================================================================
x = 'one'.capitalize()
y = 'two'.upper()

print(f'{x}')
print(type(x), type(y))

z = 'switched and 0s added "{1:<09}" "{0:>09}"'.format("zero", 'one')
print('z {}'.format(z))