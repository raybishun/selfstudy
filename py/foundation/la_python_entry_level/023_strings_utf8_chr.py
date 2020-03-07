# =============================================================================
# Strings: UTF-8 and chr()
# =============================================================================
"""
    Default encoding for strings in Python3 is UTF-8

    And you are able to access a string's Unicode code point

    Note: the (older) ASCII can hold 256 code points
"""
# -----------------------------------------------------------------------------
# UTF-8
# -----------------------------------------------------------------------------
# Get the Unicode code point for the letter 'a'
print(ord('a')) # returns --> 97

# Get the TradeMark (TM) symbol
print('\u2122')  # returns --> TM

# Get the integer value of the TM symbol
print(ord('\u2122'))  # returns -->  8482

# -----------------------------------------------------------------------------
# chr()
# -----------------------------------------------------------------------------
print(chr(8482))  # returns --> TM