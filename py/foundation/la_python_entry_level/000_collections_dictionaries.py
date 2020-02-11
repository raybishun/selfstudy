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