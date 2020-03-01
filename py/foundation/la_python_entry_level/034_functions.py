# =============================================================================
# Functions
# =============================================================================

def place_order(order_type, qty, symbol):
    return (f'{order_type}, {qty}, {symbol}')

# Positional Arguments
print(place_order('buy', 5000, 'msft'))

# Keyword Arguments
print(place_order(symbol='msft', qty=5000, order_type='buy'))
print(place_order('buy', symbol='msft', qty=5000))

# *** Note - positional arguments cannot follow keywork arguments
# print(place_order(order_type='buy', 5000, 'msft'))
print()

# -----------------------------------------------------------------------------
# Default Arguments
# -----------------------------------------------------------------------------
# *** If only one default is specified - it must be the last
# *** Otherwise, all variables in the method signature must have a default

def place_order(symbol, qty, order_type='BUY'):
    return (f'{symbol}, {qty}, {order_type}')

print(place_order('goog', 1000))
print(place_order('goog', 1000, "sell"))