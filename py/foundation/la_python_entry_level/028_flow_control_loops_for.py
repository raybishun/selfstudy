# =============================================================================
# Flow Control: Loops: For
# =============================================================================

# List
faang = ['FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG']

for stock in faang:
    print(stock)
print()

# Tuple
faang = ('FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG')

for stock in faang:
    print(stock)
print()

# Dictionary
faang = {'FB': 192.47, 'AAPL': 273.36, 'AMZN':1883.75, 'NFLX':369.03, 'GOOG':1339.33}

for k, v in faang.items():
    print(f'{k}\t{v}')
print()

# String
for c in 'faang':
    print(f'{c.upper()}', end="")