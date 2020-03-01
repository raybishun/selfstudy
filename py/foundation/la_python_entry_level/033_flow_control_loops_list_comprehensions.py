# =============================================================================
# Flow Control: Loops: List Comprehensions
# =============================================================================

faang = ['fb', 'aapl', 'amzn', 'nflx', 'goog']

# -----------------------------------------------------------------------------
# Example 1
# -----------------------------------------------------------------------------
# Working with a list...
uppercase_faang = []
for stock in faang:
    uppercase_faang.append(stock.upper())
print(uppercase_faang)

# List Comprehensions in action
uppercase_faang = [stock.upper() for stock in faang]
print(uppercase_faang)

print()
# -----------------------------------------------------------------------------
# Example 2
# -----------------------------------------------------------------------------
four_char_symbols = []
for stock in faang:
    if stock in ['aapl', 'amzn', 'nflx', 'goog_xxx']:
        four_char_symbols.append(stock)
print(four_char_symbols)

# List Comprehensions in action
four_char_symbols = [stock for stock in faang if stock in ['aapl', 'amzn', 'nflx', 'goog']]
print(four_char_symbols)