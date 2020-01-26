# =============================================================================
# Print
# =============================================================================
age = 25

# Python 2
print('the integer is: %d' % age) # where d = integer

# Python 3
print('the integer is: {}'.format(age))

# Python 3.6 introduced the 'f string'
print(f'the integer is: {age}') # where f = format

# Print on the same line
nums = [1, 2, 3]
for num in nums:
    print(num, end=' ')