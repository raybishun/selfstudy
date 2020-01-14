# =============================================================================
# Python 3 Intro
# =============================================================================
#   1. Not backward compatible
#   2. Everything is an object
#   3. Print, no longer a key-word; is now a function
#   4. Now only a single integer type for long and int
#   5. All text is now Unicode

# https://www.python.org/doc/

# The Zen of Python, by Tim Peters
# import this

import platform
version = platform.python_version()
print('Python version: {}'.format(version))

def main():
    greeting()

def greeting():
    print('Hello, World!')

if __name__ == '__main__': main()
