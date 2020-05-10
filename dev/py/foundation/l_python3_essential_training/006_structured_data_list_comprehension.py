# =============================================================================
# Structured Data - List Comprehension
# =============================================================================
"""
    Powerful way to create collections
"""
def main():
    seq = range(11)
    print_list(seq)
    print()

    # Multiple every item in the seq list by 2
    seq2 = [x * 2 for x in seq]
    print_list(seq2)
    print()

    # Multiple every item in the seq list by 2
    seq2 = [x * 2 for x in seq]
    print_list(seq2)
    print()

    # Return only itmes not divisible by 3
    seq2 = [x for x in seq if x % 3 != 0]
    print_list(seq2)
    print()

    # Create a list of tuples
    seq2 = [(x, x**2) for x in seq]
    print_list(seq2)
    print()

    # Create a list of tuples
    from math import pi
    seq2 = [round(pi, i ) for i in seq]
    print_list(seq2)
    print()

    # Create a Dictionary
    seq2 = {x: x**2 for x in seq}
    print(seq2)
    print()

    # Given a 'set', return all that is not 'a' or 'e'
    seq2 = {x for x in 'apple' if x not in 'ae'}
    print(seq2)
    print()

def print_list(o):
    for x in o:
        print(x, end = ' ')
    print()

if __name__ == '__main__': main()