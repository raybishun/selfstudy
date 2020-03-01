# =============================================================================
# Flow Control: Loops: Else
# =============================================================================

# Else in while loop
ctr = 1
while ctr <= 3:
    print(ctr)
    ctr += 1
else: 
    print("The End.")
print()

# Else in for loop
for i in [1, 2, 3]:
    print(i)
else:
    print("The End.")
print()

# Else in for loop
faang = ['FB', 'AAPL', 'AMZN', 'NFLX', 'GOOG']

q = "GOOG"

for stock in faang:
    if stock == q:
        print(f'{q} found.')
        break
else:
    print(f'{q} not found.')