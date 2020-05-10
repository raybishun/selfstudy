# =============================================================================
# If, elif, else
# =============================================================================
from datetime import date

today = date.today().weekday()

if today == 0:
    print('Monday')
elif today == 1:
    print('Tuesday')
elif today == 2:
    print('Wednesday')
elif today == 3:
    print('Thursday')
elif today == 4:
    print('Friday')
else:
    print('Unknown')