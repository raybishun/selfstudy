# =============================================================================
# File: I/O - Text Files
# =============================================================================
def main():
    
    # read mode and text mode is the default if not specified
    infile = open('010_file_io.txt', 'rt')

    outfile = open('010_file_io_copy.txt', 'wt')
    
    for line in infile:
        # print(line.rstrip(), file=outfile) or the below
        outfile.writelines(line)

        print('.', end='', flush=True)
    
    outfile.close()
    
    print('\ndone.')

if __name__ == '__main__': main()