# =============================================================================
# Classes: Exceptions
# =============================================================================
import sys

def main():
    try:
        # x = int('foo')
        x = 5/0

    except ValueError:
        print(f'{sys.exc_info()[0]}')
    except ZeroDivisionError:
        print(f'{sys.exc_info()[1]}')
    except:
        print(f'{sys.exc_info()[2]}')

if __name__ == '__main__': main()