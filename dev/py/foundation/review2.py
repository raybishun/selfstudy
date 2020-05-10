# names = ['Alice', 'Bob', 'Lance', 'Mike']
# names.insert(2, 'Jimmy')
# print(names)

# w = "la"
# print(w * 4)

# num = 15.1
# num2 = num / 4
# print(num2)
# num2 //= 2
# print(num2)
# num2 + 1
# print(num2)

# i = 5
# i //= 2
# print(i)

# ages = {'Keith': 30, 'Levi': 25, 'John': 20}
# age = ages['Kevin']
# print(ages * 2)

# def double_values(list1):
#     doubles = []
#     for num in list1:
#         doubles.append(num * 2)

# first_list = [1, 2, 3, 4]
# print(double_values(first_list))

# def hello(name, salutation):
#     print(salutation, name, sep=", ")

# hello(salutation="Howdy", name="Oscar!")

# pair1 = ('a', 'b', 'c')
# pair2 = ('d', 'e', 'f')
# index = 0

# while index < len(pair1):
#     for item in pair2:
#         print(pair2[index], item)
#     index += 1

# num = input("Enter a float value: ")
# new_num = num // 100
# print(new_num)

# letter = 'c'
# if letter < 'e':
#     print("First")
# if letter == 'b' or letter >= 'c':
#     print("Second")
# if letter < 'a':
#     print("Third")
# else:
#     print("Fourth")

# val = 1 or '2'
# val *= 3
# print(val)

# names = ['Alice', 'Bob', 'Lance', 'Mike']
# all_names = names
# # print(id(names))
# # print(id(all_names))
# names.remove('Bob')
# #all_names + ['Kevin'] # will not append to list
# # all_names.append('Ray')
# print(all_names)

# names = ['Alice', 'Lance', 'Bob', 'Mike']
# all_names = names
# names.append('Brock')
# sorted(all_names) # you need to assign this to a new list object
# # all_names = sorted(all_names)
# print(all_names)

# values = ['Kevin Bacon', 60, '555-555-5555', False]
# val = not values[1]
# print(val)

# num = 1
# new_num = str(num) + '1'
# print(new_num)

# print("1600 Pennsylvania Ave NW", "Washington", "DC", sep=', ')

# def fizz(num):
#     if num % 3 == 0 and num % 5 == 0:
#       return 'FizzBuzz'
#     elif num % 3 == 0:
#       return 'Fizz'
#     elif num % 5 == 0:
#       return 'Buzz'
#     else:
#       return num
# print(fizz(14))

# num = 12
# if num <= 15:
#     print("Less than 15")
# elif num >= 15:
#     print("Greater than 15")
# else:
#     print("Less than 15")

# letter = 'a'
# if letter < 'b':
#     print("First")
# if letter == 'b' or letter > 'c':
#     print("Second")
# elif letter <= 'a':
#     print("Third")
# else:
#     print("Fourth")

# def fizz(num):
#     if num % 3 == 0 and num % 5 == 0:
#       return print('FizzBuzz')
#     elif num % 3 == 0:
#       return 'Fizz'
#     elif num % 5 == 0:
#       return 'Buzz'
#     else:
#       return num
# fizz(15)

# ages = {'Keith': 30, 'Levi': 25, 'John': 20}
# keys = ages.keys()
# values = ages.values()
# items = ages.items()
# list_of_str = [str(value) for value in ages.values()]
# print(keys)
# print(values)
# print(items)
# print(list_of_str)

# names = ['Alice', 'Bob', 'Lance', 'Mike']
# print(names[:3])
# print(names[:4])
# print(names[:5])

# num = 10
# if num > 20 or num > 10:
#     print("First")
# elif num < 10:
#     print("Second")
# else:
#     print("Third")