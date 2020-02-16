# =============================================================================
# File: I/O - Binary Files
# =============================================================================
def main():
    # -------------------------------------------------------------------------
    # Copy a binary file
    # -------------------------------------------------------------------------
    infile = open('010_file_io_binaryfiles_spx_index.jpg', 'rb')

    outfile = open('010_file_io_binaryfiles_spx_index_copy.jpg', 'wb')
    
    while True:
        # Since don't know how large the file is,
        # you don't want to read the entire file.
        # So, in this case, we're reading 10K at a time
        buffer = infile.read(10240)
        if buffer:
            outfile.write(buffer)
            print('.', end='', flush=True)
        else:
            break
    
    outfile.close()
    
    print('\ndone.')

if __name__ == '__main__': main()