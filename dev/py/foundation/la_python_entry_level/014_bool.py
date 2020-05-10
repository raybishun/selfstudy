# =============================================================================
# Boolean Operators
# =============================================================================

# Only requires one to be True
print(f'{True or True}')    # True
print(f'{True or False}')   # True
print(f'{False or True}')   # True
print(f'{False or False}')  # False
print()

# Both must be True
print(f'{True and True}')    # True
print(f'{True and False}')   # False
print(f'{False and True}')   # False
print(f'{False and False}')  # False