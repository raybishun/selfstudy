# =============================================================================
# Functions
# =============================================================================
"""
    All functions return a value.
"""

def main():
    greeting()

def greeting():
    print('Hello World!')

# the special variable __name__ will return the name of this (current) module
# however, this is not an imported module, rather this is the 'main' file
if __name__ == '__main__': main()