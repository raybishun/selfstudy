# =============================================================================
# Flow Control: Loops: List Comprehensions
# =============================================================================

faang = ['fb', 'aapl', 'amzn', 'nflx', 'goog']

# -----------------------------------------------------------------------------
# Example 1
# -----------------------------------------------------------------------------
# Typical way for working with a list...
uppercase_faang = []
for stock in faang:
    uppercase_faang.append(stock.upper())
print(uppercase_faang) # returns --> ['FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG']

# More succinct code with List Comprehensions
uppercase_faang = [stock.upper() for stock in faang]
print(uppercase_faang) # returns --> ['FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG']

print()
# -----------------------------------------------------------------------------
# Example 2
# -----------------------------------------------------------------------------
# One approach to searching a list...
new_faang = []
for stock in faang:
    if stock in ['aapl', 'amzn', 'nflx', 'goog_xxx']:
        new_faang.append(stock)
print(new_faang)

# Using List Comprehensions to search a list
new_faang = [stock for stock in faang if stock in ['aapl', 'amzn', 'nflx', 'goog']]
print(new_faang)