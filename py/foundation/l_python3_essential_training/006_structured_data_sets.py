# =============================================================================
# Structured Data - Sets
# =============================================================================
"""
    Similiar to an (unordered) List, but does not allow duplicate elements
"""
def main():
    a = set("Life is like a box of chocolates.")
    b = set("You never know what you're gonna get.")
    print_set(a)
    print_set(b)

    # Sorted
    print()
    print_set(sorted(a))
    print_set(sorted(b))
    
    # Find what exists in set-a, but not found in set-b
    print()
    print_set(a - b)

    # Find what exists in set-a 'or' set-b
    print()
    print_set(a | b)

    # Exclusive XOR (set-a or set-b, but not both)
    print()
    print_set(a ^ b)

    # Find where set-a 'and' set-b found in both
    print()
    print_set(a & b)

def print_set(o):
    print('{', end = '')
    for x in o:
        print(x, end = '')
    print('}')

if __name__ == '__main__': main()