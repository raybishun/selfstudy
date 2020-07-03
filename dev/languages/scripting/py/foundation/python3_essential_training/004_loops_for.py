# =============================================================================
# Loop: For
# =============================================================================
names = ('batman', 'robin', 'wonder woman', 'iron man', 'flash')

for name in names:
    if name == 'robin':
        print('\trobin is out sick today, please skip him...')
        continue
    # if name == 'iron man':
    #     print('iron man: I''m outa here...')
    #     break
    print(name)
else:
    print('end-of-list.')

# -----------------------------------------------------------------------------
# Range
# -----------------------------------------------------------------------------
for num in range(3):
    print(num)