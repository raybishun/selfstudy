# =============================================================================
# Flow Control: Conditionals: if/elif/else/pass
# =============================================================================
import datetime as dt

day = dt.datetime.today().day

if day == 1:
    print('Sun')
elif day == 2:
    print('Mon')
elif day == 3:
    print('Tue')
elif day == 4:
    print('Wed')
elif day == 5:
    print('Thu')
elif day == 6:
    print('Fri')
elif day == 7:
    print('Sat')
else:
    # no-op (no operation statement)
    pass