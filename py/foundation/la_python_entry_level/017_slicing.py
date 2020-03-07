# =============================================================================
# Slicing
# =============================================================================
"""
    start:stop:stride
"""
py = "Python"

print(py[1:3]) # returns 'yt'

# Start at 2 (skip 0, 1), and return to the end
print(py[2:]) # returns 'thon'

# Get length
print(len(py)) # returns 6

# Return the last character
print(py[len(py)-1]) # returns 'n'

# Return the last character
print(py[-1]) # returns 'n'

# Return every other character
print(py[::2]) # return 'Pto'

# Clever way to reverse order of a string
print(py[::-1])