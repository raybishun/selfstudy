# =============================================================================
# type()
# =============================================================================
x = 1
print(f'{x}')
print(type(x))
print()

x = 1.618
print(f'{x}')
print(type(x))
print()

x = "one"
print(f'{x}')
print(type(x))
print()

x = {'one': 1, 'two':2, 'three':3}
for k,v in x.items():
    print(f'{k}:{v}')
print(type(x))
print()

x = [1, 'two', 3.0, [4, 'four'], 5]
print(f'{x}')
print(type(x))
print()

x = (1, 'two', 3.0, [4, 'four'], 5)
print(f'{x}')
print(type(x))