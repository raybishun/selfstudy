# =============================================================================
# File I/O Modes: 
#   1. read-only
#   2. write-only
#   3. read & write
#   4. append mode
# =============================================================================
# stdin
name = input("Enter name: ")
# stdout
print("Hello", name)

# =============================================================================
# Write to file
# =============================================================================
f = open("007fileio.txt", "w")

# Get file stats
print("file name:", f.name)
print("file closed?", f.closed)
print("file mode:", f.mode)

f.write(name)
f.close()

# =============================================================================
# Read from file
# =============================================================================
f = open("007fileio.txt", "r")
output = f.read(1)
print(output)
f.close()

print("file mode:", f.mode)
