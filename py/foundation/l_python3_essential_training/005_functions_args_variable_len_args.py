# =============================================================================
# Functions: Variable-length arguments
# =============================================================================
print('\x1b[2J')

def main():
    add(1, 2, 3)
    add(1)
    add(1, 2, 3, 4, 5)
    add()

    # Pass a tuple
    x = (1, 2, 3)
    add(*x)

def add(*args):
    if len(args):
        for arg in args:
            print(arg, end=' ')
        print()
    else:
        print("Nothing was passed in.")
		
if __name__ == '__main__': main()