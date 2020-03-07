# =============================================================================
# Collections: Tuples
# =============================================================================
"""
    Tuples are immutable

    Tip: ()
"""

work_days = ('Mon', 'Tue', 'Wed', 'Thu', 'Fri')
print(work_days) # returns --> ('Mon', 'Tue', 'Wed', 'Thu', 'Fri')
# 'tuple' object does not support item assignment
# work_days[0] = 'Sun'

# Creating a 'new' tuple
# Note, for this example, YOU MUST INCLUDE THE COMMA
# Else, it implies you are attempting some order-of-operations calculation
week = work_days + ('Sat',) 
print(week) # returns --> ('Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat')

# Unpacking tuples into variables
v, w, x, y, z = work_days
print(x) # returns --> Wed