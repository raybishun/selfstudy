# =============================================================================
# Boolean Operators
# =============================================================================
"""
    and     Both operands must be True
    or      At least one operand must be True
    not     'Unary Not'
    in      Value in collection
    not in  Value not in collection
    is      Same object ID
    is not  Different object ID
"""

# 'and' - both operands must be true
t = True
f = False
if t and f:
    print('True')
else:
    print('False')

# 'in' - check if value exists in collection
listNums = [1, 2, 3, 4, 5]
if 33 in listNums:
    print('True')
else:
    print('False')