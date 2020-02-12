# =============================================================================
# Collections: Dictionaries
# =============================================================================
# Simple way to create a dictionary
#price = {'order_type': 'buy', 'symbol': 'xom', 'open': 60.48, 'high': 60.52, 'low':59.62, 'close': 59.96, 'volume': 20641032}
# print()

# Create a dictionary using dict()
price = dict(order_type='buy', symbol='xom', open=60.48, high=60.52, low=59.62, close=59.96, volume=20641032)
print(price)
print()

# Create a dictionary using a tuple()
price2 = dict([('order_type', 'buy'), ('symbol', 'xom')])
print(price2)
print()

# Dictionaries are mutable
price['order_type'] = 'sell'
del price['volume']
print(price)
print()

# Search by key
print('close' in price)
print()

# Get keys
print(price.keys())
print(list(price.keys())) # cast to a list

# Get values
print(price.values())
print(list(price.values())) # cast to a list

# Get as tuples (returs both the keys and values)
print(price.items())
print(list(price.items()))