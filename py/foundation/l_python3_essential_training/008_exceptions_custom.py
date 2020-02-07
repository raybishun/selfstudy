# =============================================================================
# Classes: Custom Exceptions
# =============================================================================
def inclusive_range(*args):
    numargs = len(args)
    start = 0
    step = 1

    # init parameters
    if numargs < 1:
        raise TypeError(f'expected at least 1 arg, got {numargs}')
    elif numargs == 1:
        stop = args[0]
    elif numargs == 2:
        (start, stop) = args
    elif numargs == 3:
        (start, stop, step) = args
    else: raise TypeError(f'expected at most 3 args, got {numargs}')

    # generator
    i = start
    while i <= stop:
        yield i
        i += step

def main():
    try:
        for i in inclusive_range(4, 5, 6, 7):
            print(i, end=' ')
    except TypeError as e:
        print(f'{e}')

if __name__ == '__main__': main()