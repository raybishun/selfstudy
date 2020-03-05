faang_list = ['fb', 'aapl', 'amzn', 'nflx', 'goog']
faang_dict = {'FB': 192.47, 'AAPL': 273.36, 'AMZN':1883.75, 'NFLX':369.03, 'GOOG':1339.33}

# msft = faang_dict['MSFT'] # <-- does not exist
# print(faang_dict * 2)
# --> returns error

# value = input('Enter a number: ')
# print(type(value)) # return <class 'str'>
# new_value = value // 100
# print(new_value)
# --> returns error

# happy = "ha"
# print(happy * 3) 
# --> returns hahaha

# msft = faang_dict.get('MSFT')
# print(msft)
# --> returns None (get() returns None if not found)

# Operators
#   /   'regular division'
#   //  Floor Division (only returns int)
#   %   Modulo (returns only the remainder)
#   **  Power, i.e.: 2 x 2 x 2 = 8 (in math it's 2 ^ 3)

# for i in range(1,10):
#     print(i, end=' ')
# --> returns output on same line ()

# a = 50
# b = 25
# a // 2 
# print(a // 2) # --> returns 25
# print(a == b) # --> returns False (we didn't reassign anything)

# x = 1
# y = 1
# print(x == y) # --> return True
# print(id(x)) # --> returns same id
# print(id(y)) # --> returns same id

# a = 'Hello'
# b = 'World'
# print(a,b)
# --> returns 'Hello World' (w/space, because space is the default separator for print())

# num1 is a bucket
# num2 is another bucket
# num1 = 15
# num2 = num1
# num1 *= 2
# print(num1) # --> returns 30
# print(num2) # --> returns 15

# val = 1 or '2'
# print(val) # --> returns 1 (the initial value is used)
# val *= 3
# print(val) # --> returns 3 (1 * 3 = 3)

# -----------------------------------------------------------------------------
# # Space is the default separator for print()
# a = 'Hello'
# b = 'World'
# print(a,b)
# # --> returns 3 Hello World

# a = 2
# b = 1
# c = a // 2 # --> returns 1
# print(c) # --> returns 1
# print(a == b)  # --> returns False

# num = 1
# if num < 2:
#     print('< 2')
# if num > 2:
#     print('> 2')
# else:
#     print('< 2')

# num = 1
# if num < 2:
#     print('< 2')
# elif num > 2:
#     print('> 2')
# else:
#     print('< 2')

# i = 1
# if i > 2 or 1 > 1:
#     print('ok')
# elif i < 1:
#     print('ok')
# else:
#     print("nok")

# print(ord('a'))
# print(ord('b'))
# print(ord('c'))

# print(ord('a'))
# print(ord('b'))
# print(ord('c'))

# r1 = ('a', 'b' 'c')
# r2 = ('d', 'e' 'f')
# i = 0
# while i < len(r1):
#     for item in r2:
#         print(r1[i], item)
#     i += 1

# print(faang_list[:3])
# print(faang_list)

# print(faang_dict)
# print(faang_dict.keys())
# print(faang_dict.values())

# -----------------------------------------------------------------------------
# print(faang_dict)
# del faang_dict['AAPL']
# print(faang_dict)

# print(faang_dict)
# print(faang_dict.values())
# return_as_string = [str(price) for price in faang_dict.values()]
# print(return_as_string)

# *** the below lists point to the same location in memory
# print(faang_list)
# faang_list2 = faang_list
# faang_list.append('MSFT')
# sorted(faang_list2)
# print(faang_list)
# print(faang_list2)
# print(id(faang_list))
# print(id(faang_list2))

# print(faang_list)
# faang_list.insert(2, 'MSFT')
# print(faang_list)
# faang_list[2] = 'MS'
# print(faang_list)

# def greeting(name, message):
#     print(message, name, sep=", ")
# greeting("Ray", message="hi")
# greeting(name="Ray", message="hi")

# def calc(n1, n2=100):
#     n1 + n2
# print(calc(1, 2)) # --> returns None (because return statement not specified)

# def calc(n1, n2=100):
#     return n1 + n2
# print(calc(1, 2))

# The yield statement is essentially used to create a generator
# def fib(n):
#     a, b = 0, 1
#     for _ in range(1, n):
#         a, b = b, a + b
#         yield a
# get_fibs = fib(6)
# print(get_fibs)       #  --> return <generator object fib at 0x0000026BE0F65580>>
# # calling next(get_fibs) returns fib values
# print(next(get_fibs)) # --> return 1
# print(next(get_fibs)) # --> return 1
# print(next(get_fibs)) # --> return 2
# print(next(get_fibs)) # --> return 3
# print(next(get_fibs)) # --> return 5

# def test(n):
#     if n == 1:
#         return "one"
#     if n == 2:
#         return "two"
#     else:
#         return "wtf"
# print(test(2))