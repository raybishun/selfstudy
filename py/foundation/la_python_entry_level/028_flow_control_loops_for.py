# =============================================================================
# Flow Control: Loops: For
# =============================================================================

# List
faang = ['FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG']

for stock in faang:
    print(stock) # returns --> prints each item on it's own line
print()

# Tuple
faang = ('FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG')

for stock in faang:
    print(stock) # returns --> prints each item on it's own line
print()

# Dictionary
faang = {'FB': 192.47, 'AAPL': 273.36, 'AMZN':1883.75, 'NFLX':369.03, 'GOOG':1339.33}

for k, v in faang.items():
    print(f'{k}\t{v}') # returns --> prints each key \t value on it's own line
print()

# String
for each_char in 'faang':
    print(f'{each_char.upper()}', end="") # returns --> FAANG