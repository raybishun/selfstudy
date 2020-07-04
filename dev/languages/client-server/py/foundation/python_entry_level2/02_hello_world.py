# (Make hello_world.py executable on Linux)
#!/usr/bin/env python3.8

# (Make hello_world executable for the user) 
# chmod u+x hello_world.py

# (To execute, simply type the below)
# (this simply passes the .py file to the python interpreter)
# ./hello_world.py

'''
NOTE, this is actually a multi-line string - NOT a comment block 
'''

"""
NOTE, this is also a multi-line string - NOT a comment block 
"""

greeting = 'hElLo wOrLd, it\'s me :)\n'

print(greeting.lower() * 3)

print(f'{greeting}'.find('o'))

# Scientific notation
print(4.5e9)
print(4.9E9)
print(4.5e9 == 4.5 * (10 ** 9)) # 4.5 * 10 to the power of 9

print(4.5e-2) # shift the decimal 2 to the left