# =============================================================================
# Structured Data - Lists & tuples
# =============================================================================
print('\x1b[2J')

def main():
    game = ['One', 'Two', 'Three', 'Four', 'Five']
    
    # As with 'range', there's a beginning, end, step
    print(game[1:3])
    print(game[1:5:2])
    
    i = game.index('Three')
    print(game[i])

    # lists are mutable
    game.insert(0, 'Zero')
    game.append('Six')
    game.remove('Four') # remove by value
    returned_removed_value = game.pop() # remove item from end of list (default)
    print(f'{returned_removed_value} was removed')

    game.pop(1) # tell it what index to remove
    del game[1] # remove an item using the 'del' command
    del game[1:3] # remove a slice (start:end)

    print_list(game)

    print()
    game2 = ['bmw', 'mb', 'honda', 'lexus', 'ford']
    del game2[1:5:2] # del every other item bet. 1 and 5
    print(', '.join(game2))
    print(len(game2))
    print_list(game2)

    print()
    print('tuples are same as lists, but are immutable')

def print_list(o):
    for i in o:
        print(i, end=' ', flush=True)
print()

if __name__ == '__main__': main()