# =============================================================================
# Dictionary
# =============================================================================
dictionary = {'one': 1, 'two': 2, 'three': 3}

# Dictionaries are mutable
dictionary['four'] = 4

for i in dictionary:
    print(f'{i}')

for k,v in dictionary.items():
    print(f'{k}:{v}')