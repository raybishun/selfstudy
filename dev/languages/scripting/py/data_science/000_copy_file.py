# =============================================================================
# Copying a file
# =============================================================================
with open('000_copy_file.txt', 'r') as read_file:
    print(f'mode of {read_file.name}: {read_file.mode}')
    with open('000_copy_file2.txt', 'w') as write_file:
        print(f'mode of {write_file.name}: {write_file.mode}')
        for line in read_file:
            write_file.write(line)

print(f'{read_file.closed}')
print(f'{write_file.closed}')