# =============================================================================
# Strings: Methods Part 2
# =============================================================================
import os
import datetime as dt

phrase = "I failed my way to success"

# Split
words = phrase.split(' ')
print(words) # returns --> ['I', 'failed', 'my', 'way', 'to', 'success']
print()

# Join
joined_words = ", ".join(words)
print(joined_words) # returns --> I, failed, my, way, to, success
print()

joined_words = "\n".join(words)
print(joined_words) # returns --> 
# returns --> I
# returns --> failed
# returns --> my
# returns --> way
# returns --> to
# returns --> success
print()

# Format
name = os.getlogin()
year = dt.datetime.today().year

greeting = "Hello {}, it's {}!"
print(greeting.format(name, year)) # returns --> Hello ray.bishun, it's 2020!

greeting = "Hello {0}, {1} to meet you {0}.".format('Ray', 'nice')
print(greeting) # returns --> Hello Ray, nice to meet you Ray.