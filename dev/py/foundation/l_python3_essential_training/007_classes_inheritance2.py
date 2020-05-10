# =============================================================================
# Classes: Inheritance2
# =============================================================================
class ReverseText(str): # inherit from the String class
    def __str__(self): # override ctor
        return self[::-1]

def main():
    reversedText = ReverseText('Hello World.')
    print(reversedText)

if __name__ == '__main__': main()