# =============================================================================
# Dictionary
# =============================================================================
dictionary = {'one': 1, 'two': 2, 'three': 3}

# Dictionaries are key-value pairs (KVP), aka hash array, and associative arrays
# Dictionaries are mutable
dictionary['four'] = 4

for i in dictionary:
    print(f'{i}')

for k,v in dictionary.items():
    print(f'{k}:{v}')