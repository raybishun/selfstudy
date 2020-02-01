# =============================================================================
# Defining Functions
# =============================================================================
"""
    All functions return a value, ('none' by default)
"""
import os

def main():
    greeting('Hello')
	
def greeting(str):
    print(f'{str}, {os.getlogin()}')

# the special variable __name__ will return the name of the current imported 
# module, however, since in this case this script is not an imported module, 
# and is running as the main unit of execution, __main__ takes on a special 
# role, denoting that this is the 'main' file
if __name__ == '__main__': main()