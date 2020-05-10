# =============================================================================
# Function Generators
# =============================================================================
"""
    Returns a stream of values
"""

def main():
    for i in inclusive_range(25):
        print(i, end=' ')
    print()

    for i in inclusive_range(1, 10):
        print(i, end=' ')
    print()

    for i in inclusive_range(1, 10, 2):
        print(i, end=' ')
    print()

    # raise error if nothing passed
    # for i in inclusive_range():
    #     print(i, end=' ')
    # print()

    # raise error if too many args, more than 3 in this case
    # for i in inclusive_range(1, 2, 3, 4):
    #     print(i, end=' ')
    # print()

def inclusive_range(*args): # *args = Variable-length args list
    numargs = len(args)
    start = 0
    step = 1

    # initialize parameters
    if numargs < 1:
        raise TypeError(f'expected at least 1 argument, not {numargs}')
    elif numargs == 1: 
        stop = args[0] # stop, since only 1 arg was found
    elif numargs == 2:
        (start, stop) = args # start and stop, since 2 args were found
    elif numargs == 3:
        (start, stop, step) = args # start, stop, step, since 3 args were found
    else:
        raise TypeError(f'expected at most 3 arguments, got {numargs}')

    # generator
    i = start
    while i <= stop:
        yield i # yield is similar to 'return', but is used for generators
        i += step

if __name__ == '__main__': main()