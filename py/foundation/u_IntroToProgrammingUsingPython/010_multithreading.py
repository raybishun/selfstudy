# =============================================================================
# Multithreading Example
# =============================================================================
import sys
import _thread
import time

def do_work(threadinfo, delay):
    count = 0
    while count < 5:
        time.sleep(delay)
        count = count + 1
        print("%s %s" % (threadinfo, time.ctime(time.time())))

try:
    _thread.start_new_thread(do_work, ("Thread 1 -->", 2))
    _thread.start_new_thread(do_work, ("\tThread 2 -->", 4))
except:
    print(sys.exc_info()[0])

while 1:
    pass