# =============================================================================
# Floating-Point Accuracy
# =============================================================================
"""
    Floats are stored as binary fractions in RAM
    However, not all decimals are able to be represented as 
    binary fractions, i.e. 0.1 cannot actually be represented accurately

    Floats are notorious for causing rounding issues, 
    i.e. when used with money
"""
print('{0:.55}'.format(0.1))
