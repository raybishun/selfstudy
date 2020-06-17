# =============================================================================
# File: I/O
# =============================================================================
def main():
    # open file for reading (the default if not specified)
    # modes include: r=reading, w=writing, a=append
    # also:
        # r+ = read and write
        # w+ = write and read
        # a+ = append and read
    # and:
        # r+b = read binary
        # r+t = read text
        # w+b = write binary
        # w+t = write text
    f = open('010_file_io.txt', 'r')
    for line in f:
        print(line.rstrip())

if __name__ == '__main__': main()