# =============================================================================
# Functions Return Values
# =============================================================================
"""
    Python does not make any distinction
    between a procedure and a function.

    And if there isn't a return statement,
    Python returns 'None'
"""

def greeting():
    print(1)
    # return 1.618

def main():
    x = greeting()
    print(type(x), x)

if __name__ == '__main__': main()