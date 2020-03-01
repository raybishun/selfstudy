# =============================================================================
# Strings: Methods Part 2
# =============================================================================
import os
import datetime as dt

phrase = "I failed my way to success"

# Split
words = phrase.split(' ')
print(words)
print()

# Join
joined_words = ", ".join(words)
print(joined_words)
print()

joined_words = "\n".join(words)
print(joined_words)
print()

# Format
name = os.getlogin()
year = dt.datetime.today().year

greeting = "Hello {}, it's {}!"
print(greeting.format(name, year))

greeting = "Hello {0}, {1} to meet you {0}.".format('Ray', 'nice')
print(greeting)