# =============================================================================
# TODO
# 1. All functions in Python pass by ref - need to confirm this...
# =============================================================================
def greeting(str):
    "Display a greeting."
    print("Hello,", str)
    return

def changelist(list):
    "Append to list."
    list.append([34, 55, 89, 144, 233, 377])
    print("New List", list)
    return

def sum(x, y):
    "Add two integers."
    return x + y

# =============================================================================
# Consume Functions
# =============================================================================
greeting("Ray")

mylist = [1, 1, 2, 3, 5, 8, 13, 21]

changelist(mylist)

print(sum(5, 3))