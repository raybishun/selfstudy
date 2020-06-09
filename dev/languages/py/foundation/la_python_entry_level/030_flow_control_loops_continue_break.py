# =============================================================================
# Flow Control: Loops: Continue & Break
# =============================================================================

# Continue (does not exit loop)
ctr = 1
while ctr <= 10:
    if ctr % 2 == 0:
        # Skip if even
        ctr += 1
        continue
    print(f'Odd number is: {ctr}')
    ctr += 1
print()

# Break (exits the loop)
ctr = 1
while ctr <= 10:
    if ctr % 2 == 0:
        # Skip the even numbers
        ctr += 1
        break
    print(f'Odd number is: {ctr}')
    ctr += 1
print()