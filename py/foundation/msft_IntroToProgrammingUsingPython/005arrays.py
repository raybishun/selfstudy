# =============================================================================
# Single Dimensional Array
# =============================================================================
nums = { 'a', 'b', 'c', 'd', 'e' }

for num in nums:
    print(num)
    
# =============================================================================
# Two Dimensional Array
# =============================================================================
# row = fb, aapl, amzn, nflx, googl, msft
# col = open, high, low, close
faangm = [[213, 216.24, 212.61, 215.22], 
        [297.16, 304.44, 297.16, 303.19],
        [1898.04, 1911.00, 1886.44, 1891.97],
        [331.49, 342.70, 331.05, 339.26],
        [1394.82, 1411.85, 1392.63, 1405.04],
        [158.93, 160.80, 157.95, 160.09]]

print("Open\t", "High\t", "Low\t", "Close")

for row in faangm:
    for col in row:
        # print(col, end = "\t")
        print('${:,.0f}'.format(col), end = "\t")
            
        # where:
        # :,    = adds the ,
        # .0f   = number of decimal places (none in this case)

    # CRLF after each row is printed
    print()